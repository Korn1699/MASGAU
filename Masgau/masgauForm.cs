using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Security.Principal;
using Microsoft.Win32;

namespace MASGAU
{

    public partial class masgauForm : Form
    {

        public SettingsManager  settings;
        string                  program_title = "MASGAU v.0.8";
        private TaskHandler     taskmaster;
        private RestoreHandler  restore;
        private SecurityHandler red_shirt = new SecurityHandler();
        private bool            all_users_mode = false;
        private bool            redetect_games_required = false, redetect_archives_required = false;
        private int             sorted_column = 2;
        private SortOrder       sorted_order = SortOrder.Ascending;
        private invokes         invokes = new invokes();
        Thread                  setup_thread;
        private string          last_archive_create = "";
        private bool            already_updated = false;

        public masgauForm() {
            string[] args = Environment.GetCommandLineArgs();
            for(int i = 0;i<args.Length;i++) {
                if(args[i]=="/allusers") {
                    all_users_mode = true;
                }
            }
            InitializeComponent();


        }
        private void masgauForm_Shown(object sender, EventArgs e)
        {
            if (all_users_mode)
                program_title += " - All Users Mode";
            else
                program_title += " - Single User Mode";

            //progressBar1.Width = this.Width-135;
            setup_thread = new Thread(new ThreadStart(setupProgram));
            setup_thread.Start();
        }

        private void setupProgram() {
          
            buildSettings();
            invokes.setControlEnabled(tabControl1,false);

            //if(settings.height!=null) {
            //    this.Height = Int32.Parse(settings.height);
            //}

            //if(settings.width!=null) {
            //    this.Width= Int32.Parse(settings.width);
            //}


            
            if (settings.backup_path != null){
                populateRestoreList();
                invokes.setControlEnabled(tabControl1,false);
                invokes.setControlEnabled(openBackupPath,true);
            } else {
                backupPathInput.Text = "Backup path not set";
                restoreTree.Nodes.Add("Nothing", "No Backups detected");
            }

            if(settings.auto_update_enabled&&!already_updated) {
                string temp_text = progress_label.Text;
                invokes.setControlText(progress_label,"Checking For Updates...");
                checkForUpdate();
                invokes.setControlText(progress_label,temp_text);
            } 

            if (settings.sync_path != null){
                invokes.setControlEnabled(openSyncPath,true);
                syncPathInput.Text = settings.sync_path;
            } else {
                invokes.setControlText(syncPathInput,"Sync path not set");
            }

            if (settings.ignore_date_check)
                dateCheck.Checked = true;

            if(settings.auto_update_enabled) {
                autoUpdateCheck.Checked = true;
            }

            if(all_users_mode) {
                monitorCheck.Enabled = false;
            } else {
                RegistryManager reg = new RegistryManager(RegistryHive.CurrentUser,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",true);
                if(File.Exists(Path.Combine(Application.StartupPath,"Monitor.exe"))) {
                    if (reg.getValue("MASGAUMonitor")!=null) {
                        monitorCheck.Checked = true;
                    }
                } else {
                    monitorCheck.Enabled = false;
                    if (reg.getValue("MASGAUMonitor")!=null) {
                        reg.deleteValue("MASGAUMonitor");
                    }
                }

            }


			//if (settings.show_undetected)
			//    undetectedCheck.Checked = true;
            invokes.setControlText(this,program_title);
            if(all_users_mode&&File.Exists(Path.Combine(Application.StartupPath,"Task.exe"))) {
                populateTaskScheduler();
            } else {
                invokes.removeTab(tabControl1,scheduleTab);
            }

            duplicateCount.Value = settings.versioning_max;
            duplicateFrequencyNumber.Value = settings.versioning_frequency;
            duplicateFrequencyCombo.SelectedIndex = duplicateFrequencyCombo.Items.IndexOf(settings.versioning_unit);
            if(settings.versioning) {
                versioningCheck.Checked = true;
            } else {
                duplicateCount.Enabled = false;
                duplicateCountBox.Enabled = false;
                duplicateFrequencyBox.Enabled = false;
                duplicateFrequencyCombo.Enabled = false;
                duplicateFrequencyNumber.Enabled = false;
            }

            invokes.setProgressBarState(progressBar1,wyDay.Controls.ProgressBarState.Normal);

            invokes.setControlEnabled(tabControl1,true);
        }

        private void detectGames() {
            setup_thread = new Thread(new ThreadStart(buildSettings));
            setup_thread.Start();
        }
        private void detectSaves() {
            setup_thread = new Thread(new ThreadStart(populateRestoreList));
            setup_thread.Start();
        }

        private void buildSettings() {
            invokes.setControlVisible(statusPanel,true);
            invokes.setControlEnabled(tabControl1,false);
            invokes.showProgressTaskBar(progressBar1,true);
            invokes.setProgressBarValue(progressBar1,0);
            //invokes.setProgressBarState(progressBar1,wyDay.Controls.ProgressBarState.Error);
            //invokes.setControlEnabled(progressBar1,true);
            //invokes.setProgressBarStyle(progressBar1,ProgressBarStyle.Blocks);
            settings = new SettingsManager(null, null, progressBar1, progress_label, this);

            lock(settings) {
                if (settings.steam.installed) {
                    steamPathInput.Text = settings.steam.path;
                } else{
                    steamPathInput.Text = "Steam Not Detected";
                }

                populateAltList();
                populateGameList();
            }


            invokes.setControlEnabled(progressBar1,false);
            invokes.setControlEnabled(tabControl1,true);
            invokes.showProgressTaskBar(progressBar1,false);
            invokes.setProgressBarValue(progressBar1,0);
            //invokes.setProgressBarStyle(progressBar1,ProgressBarStyle.Marquee);

            if(invokes.getTab(tabControl1)!=0) {
                invokes.setControlVisible(statusPanel,false);
            } else {
                invokes.setControlVisible(statusPanel,true);
            }

            
        }

        private void populateGameList() {
            this.detectedList.Resize -= new System.EventHandler(this.detectedList_Resize);
            ListViewItem new_item;
            invokes.clearListView(detectedList);
            Dictionary<string,ArrayList> contributions = new Dictionary<string,ArrayList>();
            if (settings.games != null)
            {
                foreach(KeyValuePair<string,GameData> game in settings.games) {
                    if(game.Value.contributors.Count>0) {
                        foreach(string add_me in game.Value.contributors) {
                            if(!contributions.ContainsKey(add_me))
                                contributions[add_me] = new ArrayList();

                            contributions[add_me].Add(game.Value.title);
                        }
                    }
                    if (game.Value.detected_locations!=null&&game.Value.detected_locations.Count>0) {
                        new_item = new ListViewItem(game.Value.title);
                        new_item.ToolTipText= "";

                        foreach(KeyValuePair<string,location_holder> location in game.Value.detected_locations) {
                            new_item.ToolTipText += location.Value.getFullPath() + Environment.NewLine;
                        }
                        new_item.ToolTipText = new_item.ToolTipText.TrimEnd(Environment.NewLine.ToCharArray());
                        new_item.SubItems.Add(game.Value.platform);
                        new_item.SubItems.Add(game.Key);
                        if(game.Value.disabled)
                            new_item.ForeColor = Color.Red;
                        else 
                            new_item.ForeColor = Color.Black;
                        new_item.Group = detectedList.Groups[game.Value.platform];
                        invokes.addListViewItem(detectedList,new_item);
                        //detectedList.Items.Add(new_item);
                    } else if(settings.show_undetected) {
                        new_item = new ListViewItem(game.Value.title);
                        new_item.ToolTipText = "No Path Detected";
                        foreach(KeyValuePair<string,location_holder> location in game.Value.detected_locations) {
                            new_item.ToolTipText += location.Value.getFullPath() + Environment.NewLine;
                        }
                        new_item.ToolTipText = new_item.ToolTipText.TrimEnd(Environment.NewLine.ToCharArray());
                        new_item.SubItems.Add(game.Value.platform);
                        new_item.SubItems.Add(game.Key);
                        if (game.Value.disabled)
                            new_item.ForeColor = Color.Salmon;
                        else 
                            new_item.ForeColor = Color.Gray;
                        detectedList.Items.Add(new_item);
                    }
                }
                invokes.clearTreeView(contributorTree);
                TreeNode new_node; 
                foreach(KeyValuePair<string,ArrayList> add_me in contributions) {
                    if(add_me.Value.Count>1)
                        new_node = new TreeNode(add_me.Key + " (" + add_me.Value.Count.ToString() + " Paths)");
                    else
                        new_node = new TreeNode(add_me.Key + " (" + add_me.Value.Count.ToString() + " Path)");
                    foreach (string game_name in add_me.Value)
                    {
                        new_node.Nodes.Add(game_name);
                    }
                    invokes.addTreeNode(contributorTree,new_node);
                }
                invokes.setControlEnabled(startBackup,true);
                invokes.setControlEnabled(detectedList,true);
                invokes.setListViewScrollable(detectedList,true);
                invokes.setControlText(progress_label,detectedList.Items.Count + " Games Detected");
            }
            this.detectedList.Resize += new System.EventHandler(this.detectedList_Resize);
            if (detectedList.Items.Count == 0)
            {
                invokes.setControlEnabled(startBackup,false);
                new_item = new ListViewItem("No Games Detected");
                new_item.ToolTipText = "Where have all the games gone?";
                invokes.addListViewItem(detectedList,new_item);
                invokes.setControlText(progress_label,"No Games Detected");
                invokes.setControlEnabled(detectedList,false);
            }
            invokes.sortListView(detectedList,sorted_column,SortOrder.Ascending);
            resizeDetectedGames();
            invokes.setControlTheme(contributorTree, "explorer");
            invokes.setControlTheme(detectedList, "explorer");


        }

        private void populateAltList() {
            invokes.clearListView(altPathList);
            ListViewItem add_me;
            foreach(string new_path in settings.alt_paths) {
                add_me = new ListViewItem(new_path);
                invokes.addListViewItem(altPathList,add_me);
            }
            invokes.setControlTheme(altPathList,"explorer");
        }

        private void populateRestoreList() {
            invokes.setControlVisible(statusPanel,true);
            invokes.setControlEnabled(tabControl1,false);
            string game_count = progress_label.Text;
            invokes.setControlText(progress_label,"Scanning backups");
            if(settings.backup_path!=null) {
                restore = new RestoreHandler(settings.backup_path,null,progressBar1,progress_label);
                invokes.setControlText(backupPathInput,settings.backup_path);
            } else {
                restore = new RestoreHandler(null, null,progressBar1,progress_label);
                backupPathInput.Text = "Backup path not set";
                restoreTree.Nodes.Add("Nothing", "No Backups detected");
                invokes.setControlTheme(restoreTree,"explorer");
            }

            String game_title=null;
            invokes.clearTreeView(restoreTree);
            if(settings.backup_path!=null) {
                if(restore.backups.Count>0) {
                    foreach(KeyValuePair<string,backup_holder> add_me in restore.backups) {
                        if(settings.games!=null&&settings.games.ContainsKey(add_me.Value.game_name)) {
                            if(settings.games[add_me.Value.game_name].platform=="Windows")
                                game_title = settings.games[add_me.Value.game_name].title;
                            else
                                game_title = settings.games[add_me.Value.game_name].title + " (" + settings.games[add_me.Value.game_name].platform + ")";
                        } else  {
                            game_title = add_me.Value.file_name;
                        }
                        if(add_me.Value.owner!=null) {
                            if(!restoreTree.Nodes.ContainsKey(add_me.Value.game_name))
                                invokes.addTreeItem(restoreTree,add_me.Value.game_name, game_title);
                            invokes.addTreeSubItem(restoreTree,add_me.Value.game_name,add_me.Value.file_name, "User: " + add_me.Value.owner + " - " + add_me.Value.file_date);
                        } else {
                            if(!restoreTree.Nodes.ContainsKey(add_me.Value.game_name))
                                invokes.addTreeItem(restoreTree,add_me.Value.game_name, game_title);
                            invokes.addTreeSubItem(restoreTree,add_me.Value.game_name,add_me.Value.file_name, "Global - " + add_me.Value.file_date);
                        }
                    }
                    invokes.setControlEnabled(restoreTree,true);
                } else {
                    invokes.addTreeItem(restoreTree,"Nothing", "No Backups detected");
                    invokes.setControlEnabled(restoreTree,false);
                    invokes.setControlTheme(restoreTree,"explorer");
                }
            } else {
                invokes.setControlText(backupPathInput,"Backup path not set");
                invokes.addTreeItem(restoreTree,"Nothing", "No Backups detected");
                invokes.setControlEnabled(restoreTree,false);
                invokes.setControlTheme(restoreTree,"explorer");
            }
            invokes.setControlText(progress_label,game_count);
            redetect_archives_required = false;
            invokes.setControlEnabled(tabControl1,true);
            if(invokes.getTab(tabControl1)!=0) {
                invokes.setControlVisible(statusPanel,false);
            } else {
                invokes.setControlVisible(statusPanel,true);
            }
            invokes.setControlTheme(restoreTree,"explorer");

        }

        public bool chooseBackUpPath() {
            bool return_me = false;
            if(settings.backup_path!=null)
                folderBrowser.SelectedPath = settings.backup_path;
            folderBrowser.ShowNewFolderButton = true;
            folderBrowser.Description = "Choose where the backups will be saved.";
            if(folderBrowser.ShowDialog(this).ToString()!="Cancel") {
                if(settings.isReadable(folderBrowser.SelectedPath)) {
                    if(settings.isWritable(folderBrowser.SelectedPath)) {
                        settings.backup_path = folderBrowser.SelectedPath;
                        settings.writeConfig();
                        backupPathInput.Text = folderBrowser.SelectedPath;
                        //populateRestoreList();
                        openBackupPath.Enabled = true;
                        return_me = true;
                        redetect_archives_required = true;
                    } else {
                        MessageBox.Show(this, "You don't have permission to write to that folder.", "Freeze, Dirtbag!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return_me = false;
                    }
                } else {
                    MessageBox.Show(this, "You don't have permission to read that folder.", "Freeze, Dirtbag!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return_me = false;
                }
            }
            folderBrowser.ShowNewFolderButton = false;
            return return_me;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateRestoreList();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            settings.detectGames(null,progressBar1,progress_label, this);
            detectGames();

        }

        private void populateTaskScheduler() {
            //DirectoryEntry localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName);
            //DirectoryEntry admGroup = localMachine.Children.Find("administrators", "group");
            //object members = admGroup.Invoke("members", null);
            //foreach (object groupMember in (System.Collections.IEnumerable)members)
            //{
            //    DirectoryEntry member = new DirectoryEntry(groupMember);
            //    if(member.Name!="Administrator")
            //        taskUser.Items.Add(member.Name);
            //} 

            //for(int i=0;i<taskUser.Items.Count;i++) {
            //    if(((string)taskUser.Items[i])==Environment.UserName)
            //        taskUser.SelectedIndex=i;
            //}

            taskUser.Text = Environment.UserName;

//            red_shirt.addShield(taskApply);
//            red_shirt.addShield(deleteTask);
            taskmaster = new TaskHandler();
            if(taskmaster.schtasks_available)
                taskApply.Enabled = true;
            taskFrequency.SelectedIndex = 0;
            weekDay.SelectedIndex = 0;
            monthDay.Value = 1;
            timeOfDay.Value = taskmaster.the_times;
            switch(taskmaster.frequency) {
                case "daily":
                    taskFrequency.SelectedIndex = 0;
                    break;
                case "weekly":
                    taskFrequency.SelectedIndex = 1;
                    weekDay.SelectedIndex = taskmaster.day;
                    break;
                case "monthly":
                    taskFrequency.SelectedIndex = 2;
                    monthDay.Value = taskmaster.day;
                    break;
            }

            if(taskmaster.exists) {
                deleteTask.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(taskPassword.Text!="") {
                switch(taskFrequency.SelectedIndex) {
                    case 0:
                        taskmaster.frequency = "daily";
                        break;
                    case 1:
                        taskmaster.frequency = "weekly";
                        taskmaster.day = weekDay.SelectedIndex;
                        break;
                    case 2:
                        taskmaster.frequency = "monthly";
                        taskmaster.day = (int)monthDay.Value;
                        break;
                }
                taskmaster.the_times = timeOfDay.Value;
                taskmaster.createTask(taskUser.Text,taskPassword.Text);
                if(taskmaster.exists) {
                    deleteTask.Enabled = true;
                } else {
                    MessageBox.Show(this,"Unable to create task. Here's the excuse:" + Environment.NewLine + taskmaster.output + Environment.NewLine + "The task has been deleted.","What Did I Just Tell You",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    deleteTask.Enabled = false;
                }
            } else {
                MessageBox.Show(this, "You must enter a password for the user the task will be running as,\nwhich is shown in the little text box right there.","Pander To Me",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

        }

        private void taskFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(taskFrequency.SelectedIndex) {
                case 0:
                    weekDay.Enabled = false;
                    monthDay.Enabled = false;
                    break;
                case 1:
                    weekDay.Enabled = true;
                    monthDay.Enabled = false;
                    break;
                case 2:
                    weekDay.Enabled = false;
                    monthDay.Enabled = true;
                    break;
            }
        }

        private void ableTask_Click(object sender, EventArgs e)
        {
            taskmaster.deleteTask();
            deleteTask.Enabled = false;
        }

        private void exitMASGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startBackup_Click(sender, e);
            this.Close();
        }

        private void startBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startBackup_Click(sender, e);
        }

        public void startBackup_Click(object sender, EventArgs e)
        {
            if(settings.backup_path!=null||chooseBackUpPath()) {
                invokes.setControlVisible(this,false);
                taskForm backup = new taskForm("backup",null,settings,all_users_mode);
                backup.ShowDialog(this);
                invokes.setControlVisible(this,true);
                populateRestoreList();
            }
        }

        private void restoreTree_DoubleClick(object sender, EventArgs e)
        {
            if(restoreTree.SelectedNode!=null&&restoreTree.SelectedNode.Parent!=null) {
                invokes.setControlVisible(this,false);
                ArrayList restore_me = new ArrayList();
                restore_me.Add(Path.Combine(settings.backup_path,restoreTree.SelectedNode.Name));
                Console.WriteLine(restoreTree.SelectedNode.Name);
                taskForm restore = new taskForm("restore",restore_me,settings,all_users_mode);
                restore.ShowDialog();
                invokes.setControlVisible(this,true);
            }
        }

        private void restoreOtherSaveButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if(openFileDialog1.ShowDialog(this)==DialogResult.OK) {
                invokes.setControlVisible(this,false);
                ArrayList restore_me = new ArrayList();
                restore_me.AddRange(openFileDialog1.FileNames);
                taskForm restore = new taskForm("restore",restore_me,settings,all_users_mode);
                restore.ShowDialog();
                invokes.setControlVisible(this,true);
            }
            openFileDialog1.Multiselect = false;
        }


        // World domination code goes here
        private void detectedTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }



        private void detectedListChecker() {
            if(detectedList.SelectedItems.Count>0) {
                backupSelection.Enabled = true;
                if(detectedList.SelectedItems.Count==1) {
                    backupSelection.Text = "Back This Up";
                } else {
                    backupSelection.Text = "Back These " + detectedList.SelectedItems.Count + " Up";
                }
            } else {
                backupSelection.Enabled = false;
                backupSelection.Text = "Back Nothing Up";
            }
        }

        private void detectedList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //e.Item.Checked = e.Item.Selected;
            ////for (int i = 0; i < detectedList.Items.Count; i++)
            ////{
            ////    detectedList.Items[i].Checked = detectedList.Items[i].Selected;
            ////}
            detectedListChecker();
        }


        private void detectedList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            e.Item.Selected = e.Item.Checked;
            //this.detectedList.ItemSelectionChanged -= new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.detectedList_ItemSelectionChanged);
            //e.Item.Selected = e.Item.Checked;
            //for (int i = 0; i < detectedList.Items.Count; i++)
            //{
            //    detectedList.Items[i].Selected = detectedList.Items[i].Checked;
            //}
           // detectedListChecker();
            //this.detectedList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.detectedList_ItemSelectionChanged);
        }

        private void detectedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           // ((ListViewItem)sender).Selected = ((ListViewItem)sender).Checked;
            
        }

        private void detectedList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
			if(e.Column==0) {
                detectedList.Columns[1].Text = "Platform";
                if(sorted_column==2&&sorted_order==SortOrder.Ascending) {
                    detectedList.Columns[0].Text = "Game ۸";
                    sorted_order = SortOrder.Descending;
                } else {
                    detectedList.Columns[0].Text = "Game ۷";
                    sorted_column = 2;
                    sorted_order = SortOrder.Ascending;
                }
            } else {
                detectedList.Columns[0].Text = "Game";
                if(sorted_column==e.Column&&sorted_order==SortOrder.Ascending) {
                    detectedList.Columns[1].Text = "Platform ۸";
                    sorted_order = SortOrder.Descending;
                } else {
                    detectedList.Columns[1].Text = "Platform ۷";
                    sorted_column = e.Column;
                    sorted_order = SortOrder.Ascending;
                }
            }
		    this.detectedList.ListViewItemSorter = new ListViewItemComparer(sorted_column,sorted_order);
        }


        private void versioningCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(versioningCheck.Checked) {
                settings.versioning = true;
                duplicateCount.Enabled = true;
                settings.versioning_max = (int)duplicateCount.Value;
                duplicateCountBox.Enabled = true;
                duplicateFrequencyBox.Enabled = true;
                duplicateFrequencyCombo.Enabled = true;
                settings.versioning_unit = duplicateFrequencyCombo.SelectedItem.ToString();
                duplicateFrequencyNumber.Enabled = true;
                settings.versioning_frequency = (int)duplicateFrequencyNumber.Value;
            } else {
                settings.versioning = false;
                duplicateCount.Enabled = false;
                duplicateCountBox.Enabled = false;
                duplicateFrequencyBox.Enabled = false;
                duplicateFrequencyCombo.Enabled = false;
                duplicateFrequencyNumber.Enabled = false;
            }
            settings.writeConfig();
        }

        private void duplicateFrequencyNumber_ValueChanged(object sender, EventArgs e)
        {
            settings.versioning_frequency = (int)duplicateFrequencyNumber.Value;
            settings.writeConfig();
        }

        private void duplicateFrequencyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.versioning_unit = duplicateFrequencyCombo.SelectedItem.ToString();
            settings.writeConfig();
        }

        private void duplicateCount_ValueChanged(object sender, EventArgs e)
        {
            settings.versioning_max = (int)duplicateCount.Value;
            settings.writeConfig();
        }

        private void undetectedCheck_CheckedChanged(object sender, EventArgs e)
        {
			//if(undetectedCheck.Checked) {
			//    settings.show_undetected = true;
			//} else {
			//    settings.show_undetected = false;
			//}
            settings.writeConfig();
            populateGameList();
        }
        // Functions
        private void backupSelectedGames() {
            if (settings.backup_path != null || chooseBackUpPath())
            {
                invokes.setControlVisible(this,false);
                ArrayList these = new ArrayList();

                foreach (ListViewItem chosen in detectedList.SelectedItems)
                {
                    these.Add(chosen.SubItems[2].Text);
                }

                taskForm backup = new taskForm("backup", these, settings, all_users_mode);
                backup.ShowDialog(this);
                invokes.setControlVisible(this,true);

                populateRestoreList();
            }
        }
        private void disableSelectedGames() {
        }

        // Event handlers
        // Detected Game List Context Menu
        private void gamesContext_Opening(object sender, CancelEventArgs e)
        {
            if(detectedList.SelectedItems.Count!=0) {
                backThisUpToolStripMenuItem.Visible = true;
                disableToolStripMenuItem.Visible = true;
                purgeToolStripMenuItem.Visible = true;
                foreach(ListViewItem check_me in detectedList.SelectedItems) {
                    if(check_me.SubItems[1].Text!="Windows") {
                        purgeToolStripMenuItem.Visible = false;
                    } 
                }

                addPathToolStripMenuItem.Visible = false;
                removePathToolStripMenuItem.Visible = false;
                if (detectedList.SelectedItems.Count > 1){
                    bool show_enable = false, show_disable = false;
                    foreach(ListViewItem check_me in detectedList.SelectedItems) {
                        if(settings.games[check_me.SubItems[2].Text].disabled) {
                            show_enable = true;
                        } else {
                            show_disable = true;
                        }
                    }

                    if(show_disable&&show_enable)
                        disableToolStripMenuItem.CheckState = CheckState.Indeterminate;
                    else if(show_enable)
                        disableToolStripMenuItem.CheckState = CheckState.Checked;
                    else
                        disableToolStripMenuItem.CheckState = CheckState.Unchecked;

                    backThisUpToolStripMenuItem.Text = "Back These Up";
                    createArchiveToolStripMenuItem.Visible = false;
                } else {
                    if(settings.games[detectedList.SelectedItems[0].SubItems[2].Text].disabled) {
                        disableToolStripMenuItem.CheckState = CheckState.Checked;
                    } else {
                        disableToolStripMenuItem.CheckState = CheckState.Unchecked;
                    }
                    backThisUpToolStripMenuItem.Text = "Back This Up";
                    //addPathToolStripMenuItem.Visible = true;
					//ArrayList manual_paths = settings.getManualPaths(detectedList.SelectedItems[0].SubItems[2].Text);
					//if(manual_paths.Count>0) {
					//    removePathToolStripMenuItem.Visible = true;
					//} else {
					//    removePathToolStripMenuItem.Visible = false;
					//}
                    createArchiveToolStripMenuItem.Visible = true;
                }
            } else {
                e.Cancel = true;
            }
        }

        private void backThisUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupSelectedGames();
        }
        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem chosen in detectedList.SelectedItems){
                if(disableToolStripMenuItem.CheckState==CheckState.Checked) {
                    if(chosen.ForeColor==Color.Gray)
                        chosen.ForeColor=Color.Salmon;
                    if(chosen.ForeColor==Color.Black)
                        chosen.ForeColor=Color.Red;
                    if (!settings.disabled_games.Contains(chosen.SubItems[2].Text)) {
                        settings.disabled_games.Add(chosen.SubItems[2].Text);
                        settings.games[chosen.SubItems[2].Text].disabled = true;
                        settings.writeConfig();
                    }
                } else if(disableToolStripMenuItem.CheckState==CheckState.Unchecked) {
                    if(chosen.ForeColor==Color.Salmon)
                        chosen.ForeColor=Color.Gray;
                    if(chosen.ForeColor==Color.Red)
                        chosen.ForeColor=Color.Black;
                    if (settings.disabled_games.Contains(chosen.SubItems[2].Text)) {
                        settings.disabled_games.Remove(chosen.SubItems[2].Text);
                        settings.games[chosen.SubItems[2].Text].disabled = false;
                        settings.writeConfig();
                    }
                }
            }

        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem chosen in detectedList.SelectedItems){
                if(chosen.ForeColor==Color.Salmon)
                    chosen.ForeColor=Color.Gray;
                if(chosen.ForeColor==Color.Red)
                    chosen.ForeColor=Color.Black;
                if (settings.disabled_games.Contains(chosen.SubItems[2].Text)) {
                    settings.disabled_games.Remove(chosen.SubItems[2].Text);
                    settings.games[chosen.SubItems[2].Text].disabled = false;
                    settings.writeConfig();
                }
            }

        }
        private void purgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purgeSelector select_root;
            if (MessageBox.Show(this, "Purging erases all detected save paths for the specified game\nAre you sure you want to continue?", "This could hurt.", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return;
            foreach (ListViewItem chosen in detectedList.SelectedItems)
            {
                select_root = new purgeSelector(settings.games[chosen.SubItems[2].Text].detected_locations);
                if(select_root.purgeCombo.Items.Count>2) {
                    select_root.purgeCombo.SelectedIndex = 0;
                    if(select_root.ShowDialog(this)==DialogResult.Cancel)
                        break;
                }
                if(select_root.purgeCombo.SelectedIndex!=0){
                    try {
                        Directory.Delete(select_root.purgeCombo.SelectedItem.ToString(),true);
                    } catch {
                        MessageBox.Show(this,"Error while trying to delete this:\n" + select_root.purgeCombo.SelectedItem.ToString() + "\nYou probably don't have permission to do that.","I'm Just Not That Creative",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                } else {
                    foreach(KeyValuePair<string,location_holder> delete_me in settings.games[chosen.SubItems[2].Text].detected_locations) {
                        try {
                            Directory.Delete(delete_me.Value.getFullPath(),true);
                        } catch {
                            MessageBox.Show(this, "Error while trying to delete this:\n" + delete_me.Value.getFullPath() + "\nYou probably don't have permission to do that.", "I'm Just Not That Creative",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }

                
                
                
                select_root.Dispose();
            }
            detectGames();

        }

		private ArrayList getChecks(TreeNodeCollection nodes)
		{
			ArrayList return_me = new ArrayList();
			foreach (TreeNode node in nodes){
				if(node.Nodes.Count==0&&node.Checked)
					return_me.Add(node.FullPath);
				else 
					return_me.AddRange(getChecks(node.Nodes));
			}
			return return_me;
		}

		private void createArchiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GameData game = settings.games[detectedList.SelectedItems[0].SubItems[2].Text];
			manualBackup manual_backup = new manualBackup(game);
            this.Visible = false;
			if(manual_backup.ShowDialog(this)!=DialogResult.Cancel) {
				ArrayList selected_files = new ArrayList();
				selected_files.AddRange(getChecks(manual_backup.fileTree.Nodes));
				ArrayList back_these_up = new ArrayList();
                DateTime right_now = DateTime.Now;
				foreach(file_holder file in game.getSaves()) {
					if(selected_files.Contains(file.getFullPath()))
						back_these_up.Add(file);
				}
				if(back_these_up.Count>0) {
					if(settings.backup_path!=null&&last_archive_create=="") {
                        saveFileDialog1.InitialDirectory = settings.backup_path;
                    } else {
                        saveFileDialog1.InitialDirectory = last_archive_create;
                    }
                    if(((file_holder)back_these_up[0]).owner!=null)
                        saveFileDialog1.FileName = detectedList.SelectedItems[0].SubItems[2].Text + "«" + ((file_holder)back_these_up[0]).owner + "@" + right_now.ToString().Replace('/','-').Replace(':','-');
                    else
                        saveFileDialog1.FileName = detectedList.SelectedItems[0].SubItems[2].Text + "@" + right_now.ToString().Replace('/','-').Replace(':','-');
//				        folderBrowser.SelectedPath = settings.backup_path;

//					folderBrowser.Description = "And where would you like to put this backup??";
					if(saveFileDialog1.ShowDialog(this).ToString()!="Cancel") {
                        last_archive_create = Path.GetFullPath(saveFileDialog1.FileName);
						ArrayList one_game = new ArrayList();
						taskForm backup = new taskForm(detectedList.SelectedItems[0].SubItems[2].Text,settings,all_users_mode, back_these_up,Path.GetDirectoryName(saveFileDialog1.FileName),Path.GetFileName(saveFileDialog1.FileName));
                        manual_backup.Visible = false;
						backup.ShowDialog(this);
                        manual_backup.Visible = true;
                        this.Visible = true;
						populateRestoreList();
					}
				}
				Console.WriteLine(manual_backup.fileTree.SelectedNode.FullPath);
			}
            manual_backup.Close();
            manual_backup.Dispose();
            this.Visible = true;
		}

								// Maybe someday...

		//private void overridePathToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//    string game_name = detectedList.SelectedItems[0].SubItems[2].Text;
		//    if(settings.games[game_name].detected_roots.Count>0)
		//        folderBrowser.SelectedPath = settings.games[game_name].detected_roots[0].ToString();

		//    folderBrowser.Description = "Alright smarty-pants, where do you think this game keeps it's saves?";
		//    if(folderBrowser.ShowDialog(this).ToString()!="Cancel") {
		//        settings.addManualPath(game_name,folderBrowser.SelectedPath);
		//        settings.writeConfig();
		//    }
		//}
		//private void removePathToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//    pathSelector select_path = new pathSelector(settings.getManualPaths(detectedList.SelectedItems[0].SubItems[2].Text));
		//    if(select_path.ShowDialog(this)!=DialogResult.Cancel) {
		//        if(select_path.pathCombo.SelectedIndex==0) {
		//            settings.removeAllManualPaths(detectedList.SelectedItems[0].SubItems[2].Text);
		//        } else {
		//            settings.removeManualPath(detectedList.SelectedItems[0].SubItems[2].Text,select_path.pathCombo.SelectedItem.ToString());
		//        }
		//        settings.writeConfig();
		//    }
		//}


        private void redetectGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detectGames();
        }

        // Backup buttons
        private void backupSelection_Click(object sender, EventArgs e)
        {
            backupSelectedGames();
        }


        // Settings Tab Stuff
        // Set the backup path
        private void backupPathButton_Click(object sender, EventArgs e)
        {
            chooseBackUpPath();
        }
        // Open the backup path
        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("explorer", "\"" + backupPathInput.Text + "\"");
        }
        // Enable or disable the date check
        private void dateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (dateCheck.Checked){
                settings.ignore_date_check = true;
            }else{
                settings.ignore_date_check = false;
            }
            settings.writeConfig();
        }
        // Enable or disable monitor autostart
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegistryManager reg = new RegistryManager(RegistryHive.CurrentUser,@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",true);
            if(monitorCheck.Checked) {
                if (reg.getValue("MASGAUMonitor")==null)
                    reg.setValue("MASGAUMonitor", Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"Monitor.exe"));
            } else {
                reg.deleteValue("MASGAUMonitor");
            }
        }
        // Redetect Steam path
        private void steamClearButton_Click(object sender, EventArgs e)
        {
            settings.resetSteam();
            settings.writeConfig();
            settings.playstation = new playstationHandler();
            if (settings.steam.installed)
                steamPathInput.Text = settings.steam.path;
            else
                steamPathInput.Text = "Steam Not Detected";
            redetect_games_required = true;
        }
        // Manually set Steam path
        private void steamPathButton_Click(object sender, EventArgs e)
        {
            if(settings.steam.path!=null)
                folderBrowser.SelectedPath = settings.steam.path;
            folderBrowser.Description = "Choose where Steam is located.";
            if(folderBrowser.ShowDialog(this).ToString()!="Cancel") {
                settings.overrideSteam(folderBrowser.SelectedPath);
                settings.writeConfig();
                settings.playstation = new playstationHandler();
                if (settings.steam.installed)
                    steamPathInput.Text = settings.steam.path;
                else
                    steamPathInput.Text = "Steam Not Detected";
                redetect_games_required = true;
            }
        }
        // Changes the alt path remove button text and enability
        private void altPathList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (altPathList.SelectedItems.Count > 1){
                removePath.Enabled = true;
                removePath.Text = "Remove Paths";
            }
            else if (altPathList.SelectedItems.Count > 0){
                removePath.Enabled = true;
                removePath.Text = "Remove Path";
            }
            else{
                removePath.Enabled = false;
                removePath.Text = "Remove Nothing";
            }
        }
        // Removes alt paths
        private void removePath_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem remove_me in altPathList.SelectedItems) {
                if(settings.alt_paths.Contains(remove_me.Text))
                    settings.alt_paths.Remove(remove_me.Text);
            }

            settings.writeConfig();
            redetect_games_required = true;   
            populateAltList();
        }
        // Adds alt paths
        private void addPath_Click(object sender, EventArgs e) {
            folderBrowser.Description = "Choose an additional path to search for games under.";
            folderBrowser.SelectedPath = Environment.GetLogicalDrives()[0];
            if(folderBrowser.ShowDialog(this).ToString()!="Cancel") {
                settings.addAltPath(folderBrowser.SelectedPath);
                settings.writeConfig();
                redetect_games_required = true;
                populateAltList();
            }
        }


        // On tab change, if something happened that necessitates redetecting the games, do it
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(redetect_games_required||redetect_archives_required) {
                if (redetect_games_required) {
                    detectGames();
                    redetect_games_required = false;
                }
                if(redetect_archives_required) {
                    detectSaves();
                    redetect_archives_required = false;
                }
            } else {
                if(invokes.getTab(tabControl1)!=0) {
                    invokes.setControlVisible(statusPanel,false);
                } else {
                    invokes.setControlVisible(statusPanel,true);
                }
            }
        }

        private void detectedList_Resize(object sender, EventArgs e)
        {
            resizeDetectedGames();
        }


        private delegate void resizeDetectedGamesDelegate();
        private void resizeDetectedGames() {
            if (detectedList.InvokeRequired)
            {
                detectedList.BeginInvoke(new resizeDetectedGamesDelegate(resizeDetectedGames));
            }
            else
            {
                lock (detectedList)
                {
                    try
                    {
                        if (detectedList.Items.Count > 0 && detectedList.ClientSize.Height < (detectedList.Items.Count + 1) * detectedList.Items[0].Bounds.Height)
                        {
                            detectedList.Scrollable = true;
                            detectedList.Columns[0].Width = detectedList.Width - 100;
                            detectedList.TileSize = new Size(detectedList.Width - 75,detectedList.TileSize.Height);
                        }
                        else
                        {
                            detectedList.Scrollable = false;
                            detectedList.Columns[0].Width = detectedList.Width-85;
                            detectedList.TileSize = new Size(detectedList.Width-60,detectedList.TileSize.Height);
                        }
                        detectedList.Columns[1].Width = 75;
                        detectedList.Columns[2].Width = 0;
                    }
                    catch { }
                }
                invokes.setControlTheme(detectedList, "explorer");
            }
        }

        private void altPathList_Resize(object sender, EventArgs e)
        {
            altPathList.Columns[0].Width = altPathList.Width-5;
        }

        private void masgauForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(setup_thread.IsAlive)
                setup_thread.Abort();
            //settings.writeConfig();
        }

        private void masgauForm_ResizeEnd(object sender, EventArgs e)
        {
            //settings.height = this.Height.ToString();
            //settings.width = this.Width.ToString();
        }

        private void masgauForm_Resize(object sender, EventArgs e)
        {
            //progressBar1.Width = this.Width-135;

        }

        private void masgauForm_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void redetectButton_Click(object sender, EventArgs e)
        {
            detectGames();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://masgau.sourceforge.net/");

        }

        private void openSyncPath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "\"" + syncPathInput.Text + "\"");
        }

        private void syncPathButton_Click(object sender, EventArgs e)
        {
            chooseSyncPath();
        }
        public bool chooseSyncPath() {
            bool return_me = false;
            if(settings.sync_path!=null)
                folderBrowser.SelectedPath = settings.sync_path;
            folderBrowser.ShowNewFolderButton = true;
            folderBrowser.Description = "Choose where the syncs will be made.";
            if(folderBrowser.ShowDialog(this).ToString()!="Cancel") {
                if(settings.isReadable(folderBrowser.SelectedPath)) {
                    if(settings.isWritable(folderBrowser.SelectedPath)) {
                        settings.sync_path= folderBrowser.SelectedPath;
                        settings.writeConfig();
                        syncPathInput.Text = settings.sync_path;
                        openSyncPath.Enabled = true;
                        return_me = true;
                    } else {
                        MessageBox.Show(this, "You don't have permission to write to that folder.", "It's Blue!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return_me = false;
                    }
                } else {
                    MessageBox.Show(this, "You don't have permission to read that folder.", "It's Green!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return_me = false;
                }
            }
            folderBrowser.ShowNewFolderButton = false;
            return return_me;
        }

        private void autoUpdateCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.auto_update_enabled = autoUpdateCheck.Checked;
            settings.writeConfig();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(checkForUpdate()=="none") {
                invokes.showMessageBox(this,"Move along","No updates found.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public string checkForUpdate() {
            updateHandler updates = new updateHandler();
            already_updated = true;
            if(updates.checkVersions()) {
                if(updates.update_program) {
                    programUpdateForm program_update = new programUpdateForm(updates.latest_program_version.path);
                    if(invokes.showDialog(this,program_update)==DialogResult.OK) {
                        invokes.closeForm(this);
                        return "updated";
                    } else {
                        return "declined";
                    }
                } else {
                    if(File.Exists("Updater.exe")) {
                        if(invokes.showConfirmDialog(this,"MASGAU wishes to evolve","There are data updates available." + Environment.NewLine + "Would you like to update?")==DialogResult.Yes) {
                            invokes.setControlVisible(this,false);
                            ProcessStartInfo updater = new ProcessStartInfo();
                            updater.FileName = Path.Combine(Application.StartupPath,"Updater.exe");
                            SecurityHandler red_shirt = new SecurityHandler();
                            if(!red_shirt.amAdmin()) {
                                updater.Verb =  "runas";
                            }
                            try {
		                        using(Process p = Process.Start(updater)) {
                                    p.WaitForExit();
                                }
                            } catch {
                                //invokes.showMessageBox(this,"Something's wrong","The update process failed with this excuse:" + Environment.NewLine + exception.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                            invokes.setControlVisible(this,true);

                            if(invokes.getTab(tabControl1)!=0) {
                                redetect_games_required = true;
                            } else {
                                detectGames();
                            }
                            return "updated";
                        } else {
                            return "declined";
                        }
                    } else {
                        invokes.showMessageBox(this,"How could you let this happen?","The updater executable is missing." + Environment.NewLine + "You'll probably have to reinstall MASGAU before updating will work again",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return "error";
                    }
                }
            } else {
                return "none";
            }
        }

        private void refreshArchivesButton_Click(object sender, EventArgs e)
        {
            statusPanel.Visible = true;
            populateRestoreList();
            redetect_games_required = false;
            statusPanel.Visible = false;

        }


        private void showPathToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        

    }
}