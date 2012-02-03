namespace MASGAU
{
    partial class masgauForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Windows", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("PlayStation", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("PlayStation 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("PlayStation 3", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("PlayStation Portable", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masgauForm));
            this.gamesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backThisUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.backupTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.redetectButton = new System.Windows.Forms.Button();
            this.startBackup = new System.Windows.Forms.Button();
            this.backupSelection = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.detectedList = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.platform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.restoreTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.restoreTree = new System.Windows.Forms.TreeView();
            this.restoreContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreOtherSaveButton = new System.Windows.Forms.Button();
            this.refreshArchivesButton = new System.Windows.Forms.Button();
            this.scheduleTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.taskFrequency = new System.Windows.Forms.ComboBox();
            this.taskApply = new System.Windows.Forms.Button();
            this.deleteTask = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.taskUser = new System.Windows.Forms.TextBox();
            this.taskPassword = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.timeOfDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.monthDay = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.weekDay = new System.Windows.Forms.ComboBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.versioningCheck = new System.Windows.Forms.CheckBox();
            this.duplicateCountBox = new System.Windows.Forms.GroupBox();
            this.duplicateCount = new System.Windows.Forms.NumericUpDown();
            this.duplicateFrequencyBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.duplicateFrequencyNumber = new System.Windows.Forms.NumericUpDown();
            this.duplicateFrequencyCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.removePath = new System.Windows.Forms.Button();
            this.altPathList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addPath = new System.Windows.Forms.Button();
            this.monitorCheck = new System.Windows.Forms.CheckBox();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.steamClearButton = new System.Windows.Forms.Button();
            this.steamPathInput = new System.Windows.Forms.TextBox();
            this.steamPathButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.backupPathInput = new System.Windows.Forms.TextBox();
            this.openBackupPath = new System.Windows.Forms.Button();
            this.backupPathButton = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.syncPathInput = new System.Windows.Forms.TextBox();
            this.openSyncPath = new System.Windows.Forms.Button();
            this.syncPathButton = new System.Windows.Forms.Button();
            this.autoUpdateCheck = new System.Windows.Forms.CheckBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.contributorTree = new System.Windows.Forms.TreeView();
            this.progressBar1 = new wyDay.Controls.Windows7ProgressBar();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.altPathContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.statusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.progress_label = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gamesContext.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.backupTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.restoreTab.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.scheduleTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthDay)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.duplicateCountBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateCount)).BeginInit();
            this.duplicateFrequencyBox.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateFrequencyNumber)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.altPathContext.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesContext
            // 
            this.gamesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createArchiveToolStripMenuItem,
            this.backThisUpToolStripMenuItem,
            this.addPathToolStripMenuItem,
            this.removePathToolStripMenuItem,
            this.purgeToolStripMenuItem,
            this.toolStripSeparator1,
            this.disableToolStripMenuItem});
            this.gamesContext.Name = "gamesContext";
            this.gamesContext.ShowCheckMargin = true;
            this.gamesContext.ShowImageMargin = false;
            this.gamesContext.Size = new System.Drawing.Size(197, 142);
            this.gamesContext.Opening += new System.ComponentModel.CancelEventHandler(this.gamesContext_Opening);
            // 
            // createArchiveToolStripMenuItem
            // 
            this.createArchiveToolStripMenuItem.Name = "createArchiveToolStripMenuItem";
            this.createArchiveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.createArchiveToolStripMenuItem.Text = "Create Custom Archive";
            this.createArchiveToolStripMenuItem.Click += new System.EventHandler(this.createArchiveToolStripMenuItem_Click);
            // 
            // backThisUpToolStripMenuItem
            // 
            this.backThisUpToolStripMenuItem.Name = "backThisUpToolStripMenuItem";
            this.backThisUpToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.backThisUpToolStripMenuItem.Text = "Back Nothing Up";
            this.backThisUpToolStripMenuItem.Click += new System.EventHandler(this.backThisUpToolStripMenuItem_Click);
            // 
            // addPathToolStripMenuItem
            // 
            this.addPathToolStripMenuItem.Name = "addPathToolStripMenuItem";
            this.addPathToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addPathToolStripMenuItem.Text = "Add Manual Path";
            // 
            // removePathToolStripMenuItem
            // 
            this.removePathToolStripMenuItem.Name = "removePathToolStripMenuItem";
            this.removePathToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removePathToolStripMenuItem.Text = "Remove Manual Path";
            // 
            // purgeToolStripMenuItem
            // 
            this.purgeToolStripMenuItem.Name = "purgeToolStripMenuItem";
            this.purgeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.purgeToolStripMenuItem.Text = "Purge";
            this.purgeToolStripMenuItem.Click += new System.EventHandler(this.purgeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.CheckOnClick = true;
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.backupTab);
            this.tabControl1.Controls.Add(this.restoreTab);
            this.tabControl1.Controls.Add(this.scheduleTab);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Controls.Add(this.aboutTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 364);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // backupTab
            // 
            this.backupTab.Controls.Add(this.tableLayoutPanel3);
            this.backupTab.Location = new System.Drawing.Point(4, 22);
            this.backupTab.Margin = new System.Windows.Forms.Padding(0);
            this.backupTab.Name = "backupTab";
            this.backupTab.Size = new System.Drawing.Size(450, 338);
            this.backupTab.TabIndex = 0;
            this.backupTab.Text = "Backup";
            this.backupTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.redetectButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.startBackup, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.backupSelection, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 338);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // redetectButton
            // 
            this.redetectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redetectButton.Location = new System.Drawing.Point(3, 311);
            this.redetectButton.Name = "redetectButton";
            this.redetectButton.Size = new System.Drawing.Size(143, 24);
            this.redetectButton.TabIndex = 6;
            this.redetectButton.Text = "Redetect Games";
            this.redetectButton.UseVisualStyleBackColor = true;
            this.redetectButton.Click += new System.EventHandler(this.redetectButton_Click);
            // 
            // startBackup
            // 
            this.startBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBackup.Location = new System.Drawing.Point(302, 311);
            this.startBackup.Name = "startBackup";
            this.startBackup.Size = new System.Drawing.Size(145, 24);
            this.startBackup.TabIndex = 5;
            this.startBackup.Text = "Back Everything Up";
            this.startBackup.UseVisualStyleBackColor = true;
            this.startBackup.Click += new System.EventHandler(this.startBackup_Click);
            // 
            // backupSelection
            // 
            this.backupSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupSelection.Enabled = false;
            this.backupSelection.Location = new System.Drawing.Point(152, 311);
            this.backupSelection.Name = "backupSelection";
            this.backupSelection.Size = new System.Drawing.Size(144, 24);
            this.backupSelection.TabIndex = 4;
            this.backupSelection.Text = "Back Nothing Up";
            this.backupSelection.UseVisualStyleBackColor = true;
            this.backupSelection.Click += new System.EventHandler(this.backupSelection_Click);
            // 
            // groupBox5
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox5, 3);
            this.groupBox5.Controls.Add(this.detectedList);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 3);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(450, 305);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detected Games";
            // 
            // detectedList
            // 
            this.detectedList.AllowColumnReorder = true;
            this.detectedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detectedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.platform,
            this.name});
            this.detectedList.ContextMenuStrip = this.gamesContext;
            this.detectedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detectedList.FullRowSelect = true;
            listViewGroup1.Header = "Windows";
            listViewGroup1.Name = "Windows";
            listViewGroup2.Header = "PlayStation";
            listViewGroup2.Name = "PS1";
            listViewGroup3.Header = "PlayStation 2";
            listViewGroup3.Name = "PS2";
            listViewGroup4.Header = "PlayStation 3";
            listViewGroup4.Name = "PS3";
            listViewGroup5.Header = "PlayStation Portable";
            listViewGroup5.Name = "PSP";
            this.detectedList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.detectedList.HideSelection = false;
            this.detectedList.LabelWrap = false;
            this.detectedList.Location = new System.Drawing.Point(5, 18);
            this.detectedList.Name = "detectedList";
            this.detectedList.ShowGroups = false;
            this.detectedList.ShowItemToolTips = true;
            this.detectedList.Size = new System.Drawing.Size(440, 282);
            this.detectedList.SmallImageList = this.imageList1;
            this.detectedList.TabIndex = 2;
            this.detectedList.TileSize = new System.Drawing.Size(168, 30);
            this.detectedList.UseCompatibleStateImageBehavior = false;
            this.detectedList.View = System.Windows.Forms.View.Details;
            this.detectedList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.detectedList_ColumnClick);
            this.detectedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.detectedList_ItemCheck);
            this.detectedList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.detectedList_ItemChecked);
            this.detectedList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.detectedList_ItemSelectionChanged);
            this.detectedList.Resize += new System.EventHandler(this.detectedList_Resize);
            // 
            // title
            // 
            this.title.DisplayIndex = 1;
            this.title.Text = "Game ۷";
            this.title.Width = 364;
            // 
            // platform
            // 
            this.platform.DisplayIndex = 2;
            this.platform.Text = "Platform";
            // 
            // name
            // 
            this.name.DisplayIndex = 0;
            this.name.Text = "Secret Name! Ssssh!";
            this.name.Width = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(5, 5);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // restoreTab
            // 
            this.restoreTab.Controls.Add(this.tableLayoutPanel15);
            this.restoreTab.Location = new System.Drawing.Point(4, 22);
            this.restoreTab.Margin = new System.Windows.Forms.Padding(0);
            this.restoreTab.Name = "restoreTab";
            this.restoreTab.Size = new System.Drawing.Size(450, 338);
            this.restoreTab.TabIndex = 2;
            this.restoreTab.Text = "Restore";
            this.restoreTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.restoreOtherSaveButton, 1, 1);
            this.tableLayoutPanel15.Controls.Add(this.refreshArchivesButton, 0, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(450, 338);
            this.tableLayoutPanel15.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.tableLayoutPanel15.SetColumnSpan(this.groupBox4, 2);
            this.groupBox4.Controls.Add(this.restoreTree);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(450, 305);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Double-click a backup to restore it";
            // 
            // restoreTree
            // 
            this.restoreTree.ContextMenuStrip = this.restoreContext;
            this.restoreTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restoreTree.FullRowSelect = true;
            this.restoreTree.Location = new System.Drawing.Point(5, 18);
            this.restoreTree.Name = "restoreTree";
            this.restoreTree.Size = new System.Drawing.Size(440, 282);
            this.restoreTree.TabIndex = 0;
            this.restoreTree.DoubleClick += new System.EventHandler(this.restoreTree_DoubleClick);
            // 
            // restoreContext
            // 
            this.restoreContext.Name = "contextMenuStrip1";
            this.restoreContext.Size = new System.Drawing.Size(61, 4);
            // 
            // restoreOtherSaveButton
            // 
            this.restoreOtherSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restoreOtherSaveButton.Location = new System.Drawing.Point(228, 311);
            this.restoreOtherSaveButton.Name = "restoreOtherSaveButton";
            this.restoreOtherSaveButton.Size = new System.Drawing.Size(219, 24);
            this.restoreOtherSaveButton.TabIndex = 2;
            this.restoreOtherSaveButton.Text = "Restore Other Save(s)";
            this.restoreOtherSaveButton.UseVisualStyleBackColor = true;
            this.restoreOtherSaveButton.Click += new System.EventHandler(this.restoreOtherSaveButton_Click);
            // 
            // refreshArchivesButton
            // 
            this.refreshArchivesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshArchivesButton.Location = new System.Drawing.Point(3, 311);
            this.refreshArchivesButton.Name = "refreshArchivesButton";
            this.refreshArchivesButton.Size = new System.Drawing.Size(219, 24);
            this.refreshArchivesButton.TabIndex = 3;
            this.refreshArchivesButton.Text = "Reload Archives";
            this.refreshArchivesButton.UseVisualStyleBackColor = true;
            this.refreshArchivesButton.Click += new System.EventHandler(this.refreshArchivesButton_Click);
            // 
            // scheduleTab
            // 
            this.scheduleTab.Controls.Add(this.tableLayoutPanel2);
            this.scheduleTab.Location = new System.Drawing.Point(4, 22);
            this.scheduleTab.Name = "scheduleTab";
            this.scheduleTab.Size = new System.Drawing.Size(450, 338);
            this.scheduleTab.TabIndex = 3;
            this.scheduleTab.Text = "Schedule";
            this.scheduleTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.taskApply, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.deleteTask, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox8, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(450, 338);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox6, 2);
            this.groupBox6.Controls.Add(this.taskFrequency);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(444, 45);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Frequency";
            // 
            // taskFrequency
            // 
            this.taskFrequency.DisplayMember = "Daily";
            this.taskFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskFrequency.FormattingEnabled = true;
            this.taskFrequency.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.taskFrequency.Location = new System.Drawing.Point(5, 18);
            this.taskFrequency.Name = "taskFrequency";
            this.taskFrequency.Size = new System.Drawing.Size(434, 21);
            this.taskFrequency.TabIndex = 1;
            this.taskFrequency.SelectedIndexChanged += new System.EventHandler(this.taskFrequency_SelectedIndexChanged);
            // 
            // taskApply
            // 
            this.taskApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskApply.Enabled = false;
            this.taskApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskApply.Location = new System.Drawing.Point(228, 311);
            this.taskApply.Name = "taskApply";
            this.taskApply.Size = new System.Drawing.Size(219, 24);
            this.taskApply.TabIndex = 0;
            this.taskApply.Text = "Apply";
            this.taskApply.UseVisualStyleBackColor = true;
            this.taskApply.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteTask
            // 
            this.deleteTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteTask.Enabled = false;
            this.deleteTask.Location = new System.Drawing.Point(3, 311);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(219, 24);
            this.deleteTask.TabIndex = 8;
            this.deleteTask.Text = "Delete Task";
            this.deleteTask.UseVisualStyleBackColor = true;
            this.deleteTask.Click += new System.EventHandler(this.ableTask_Click);
            // 
            // groupBox7
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox7, 2);
            this.groupBox7.Controls.Add(this.tableLayoutPanel4);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 205);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(444, 44);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "User And Password To Run Task As";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.taskUser, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.taskPassword, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(440, 27);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // taskUser
            // 
            this.taskUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskUser.Enabled = false;
            this.taskUser.Location = new System.Drawing.Point(3, 3);
            this.taskUser.Name = "taskUser";
            this.taskUser.Size = new System.Drawing.Size(214, 20);
            this.taskUser.TabIndex = 1;
            // 
            // taskPassword
            // 
            this.taskPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskPassword.Location = new System.Drawing.Point(223, 3);
            this.taskPassword.Name = "taskPassword";
            this.taskPassword.PasswordChar = '§';
            this.taskPassword.Size = new System.Drawing.Size(214, 20);
            this.taskPassword.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox10, 2);
            this.groupBox10.Controls.Add(this.timeOfDay);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 54);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox10.Size = new System.Drawing.Size(444, 44);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Time of Day";
            // 
            // timeOfDay
            // 
            this.timeOfDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeOfDay.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeOfDay.Location = new System.Drawing.Point(5, 18);
            this.timeOfDay.Name = "timeOfDay";
            this.timeOfDay.ShowUpDown = true;
            this.timeOfDay.Size = new System.Drawing.Size(434, 20);
            this.timeOfDay.TabIndex = 0;
            this.timeOfDay.Value = new System.DateTime(2009, 7, 5, 0, 0, 0, 0);
            // 
            // groupBox11
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox11, 2);
            this.groupBox11.Controls.Add(this.monthDay);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 155);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox11.Size = new System.Drawing.Size(444, 44);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Day of the Month";
            // 
            // monthDay
            // 
            this.monthDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthDay.Location = new System.Drawing.Point(5, 18);
            this.monthDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.monthDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthDay.Name = "monthDay";
            this.monthDay.Size = new System.Drawing.Size(434, 20);
            this.monthDay.TabIndex = 0;
            this.monthDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox8
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox8, 2);
            this.groupBox8.Controls.Add(this.weekDay);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 104);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox8.Size = new System.Drawing.Size(444, 45);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Day of the Week";
            // 
            // weekDay
            // 
            this.weekDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weekDay.FormattingEnabled = true;
            this.weekDay.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.weekDay.Location = new System.Drawing.Point(5, 18);
            this.weekDay.Name = "weekDay";
            this.weekDay.Size = new System.Drawing.Size(434, 21);
            this.weekDay.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.tableLayoutPanel5);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(2);
            this.settingsTab.Size = new System.Drawing.Size(450, 338);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox9, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.monitorCheck, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateCheck, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.groupBox13, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.autoUpdateCheck, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.updateButton, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(446, 334);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel9);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(2, 156);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(219, 176);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.versioningCheck, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.duplicateCountBox, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.duplicateFrequencyBox, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(213, 157);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // versioningCheck
            // 
            this.versioningCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.versioningCheck.AutoSize = true;
            this.versioningCheck.BackColor = System.Drawing.Color.Transparent;
            this.versioningCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versioningCheck.Location = new System.Drawing.Point(3, 3);
            this.versioningCheck.Name = "versioningCheck";
            this.versioningCheck.Size = new System.Drawing.Size(207, 24);
            this.versioningCheck.TabIndex = 0;
            this.versioningCheck.Text = "Make Extra Backups";
            this.versioningCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versioningCheck.UseVisualStyleBackColor = false;
            this.versioningCheck.CheckedChanged += new System.EventHandler(this.versioningCheck_CheckedChanged);
            // 
            // duplicateCountBox
            // 
            this.duplicateCountBox.Controls.Add(this.duplicateCount);
            this.duplicateCountBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duplicateCountBox.Location = new System.Drawing.Point(3, 85);
            this.duplicateCountBox.Name = "duplicateCountBox";
            this.duplicateCountBox.Size = new System.Drawing.Size(207, 41);
            this.duplicateCountBox.TabIndex = 2;
            this.duplicateCountBox.TabStop = false;
            this.duplicateCountBox.Text = "At Most This Many Copies";
            // 
            // duplicateCount
            // 
            this.duplicateCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duplicateCount.Location = new System.Drawing.Point(3, 16);
            this.duplicateCount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.duplicateCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duplicateCount.Name = "duplicateCount";
            this.duplicateCount.Size = new System.Drawing.Size(201, 20);
            this.duplicateCount.TabIndex = 0;
            this.duplicateCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duplicateCount.ValueChanged += new System.EventHandler(this.duplicateCount_ValueChanged);
            // 
            // duplicateFrequencyBox
            // 
            this.duplicateFrequencyBox.Controls.Add(this.tableLayoutPanel10);
            this.duplicateFrequencyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duplicateFrequencyBox.Location = new System.Drawing.Point(3, 33);
            this.duplicateFrequencyBox.Name = "duplicateFrequencyBox";
            this.duplicateFrequencyBox.Size = new System.Drawing.Size(207, 46);
            this.duplicateFrequencyBox.TabIndex = 1;
            this.duplicateFrequencyBox.TabStop = false;
            this.duplicateFrequencyBox.Text = "At Least This Long Between Copies";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.duplicateFrequencyNumber, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.duplicateFrequencyCombo, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(201, 27);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // duplicateFrequencyNumber
            // 
            this.duplicateFrequencyNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duplicateFrequencyNumber.Location = new System.Drawing.Point(3, 3);
            this.duplicateFrequencyNumber.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.duplicateFrequencyNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duplicateFrequencyNumber.Name = "duplicateFrequencyNumber";
            this.duplicateFrequencyNumber.Size = new System.Drawing.Size(94, 20);
            this.duplicateFrequencyNumber.TabIndex = 0;
            this.duplicateFrequencyNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.duplicateFrequencyNumber.ValueChanged += new System.EventHandler(this.duplicateFrequencyNumber_ValueChanged);
            // 
            // duplicateFrequencyCombo
            // 
            this.duplicateFrequencyCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duplicateFrequencyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duplicateFrequencyCombo.FormattingEnabled = true;
            this.duplicateFrequencyCombo.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Weeks",
            "Months",
            "Years",
            "Decades",
            "Centuries",
            "Millenia"});
            this.duplicateFrequencyCombo.Location = new System.Drawing.Point(103, 3);
            this.duplicateFrequencyCombo.Name = "duplicateFrequencyCombo";
            this.duplicateFrequencyCombo.Size = new System.Drawing.Size(95, 21);
            this.duplicateFrequencyCombo.TabIndex = 1;
            this.duplicateFrequencyCombo.SelectedIndexChanged += new System.EventHandler(this.duplicateFrequencyCombo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(225, 156);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 176);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alternate Install Paths";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.removePath, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.altPathList, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.addPath, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(213, 157);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // removePath
            // 
            this.removePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removePath.Enabled = false;
            this.removePath.Location = new System.Drawing.Point(3, 130);
            this.removePath.Name = "removePath";
            this.removePath.Size = new System.Drawing.Size(100, 24);
            this.removePath.TabIndex = 8;
            this.removePath.Text = "Remove Nothing";
            this.removePath.UseVisualStyleBackColor = true;
            this.removePath.Click += new System.EventHandler(this.removePath_Click);
            // 
            // altPathList
            // 
            this.altPathList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.tableLayoutPanel6.SetColumnSpan(this.altPathList, 2);
            this.altPathList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.altPathList.FullRowSelect = true;
            this.altPathList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.altPathList.HideSelection = false;
            this.altPathList.Location = new System.Drawing.Point(3, 3);
            this.altPathList.Name = "altPathList";
            this.altPathList.ShowItemToolTips = true;
            this.altPathList.Size = new System.Drawing.Size(207, 121);
            this.altPathList.TabIndex = 0;
            this.altPathList.UseCompatibleStateImageBehavior = false;
            this.altPathList.View = System.Windows.Forms.View.List;
            this.altPathList.SelectedIndexChanged += new System.EventHandler(this.altPathList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 200;
            // 
            // addPath
            // 
            this.addPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPath.Location = new System.Drawing.Point(109, 130);
            this.addPath.Name = "addPath";
            this.addPath.Size = new System.Drawing.Size(101, 24);
            this.addPath.TabIndex = 1;
            this.addPath.Text = "Add New Path!";
            this.addPath.UseVisualStyleBackColor = true;
            this.addPath.Click += new System.EventHandler(this.addPath_Click);
            // 
            // monitorCheck
            // 
            this.monitorCheck.AutoSize = true;
            this.monitorCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitorCheck.Location = new System.Drawing.Point(226, 3);
            this.monitorCheck.Name = "monitorCheck";
            this.monitorCheck.Size = new System.Drawing.Size(217, 21);
            this.monitorCheck.TabIndex = 6;
            this.monitorCheck.Text = "Start Monitor On Login";
            this.monitorCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monitorCheck.UseVisualStyleBackColor = true;
            this.monitorCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateCheck
            // 
            this.dateCheck.AutoSize = true;
            this.dateCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateCheck.Location = new System.Drawing.Point(3, 3);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(217, 21);
            this.dateCheck.TabIndex = 5;
            this.dateCheck.Text = "Ignore Dates During Backup";
            this.dateCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateCheck.UseVisualStyleBackColor = true;
            this.dateCheck.CheckedChanged += new System.EventHandler(this.dateCheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(442, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Steam Path";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.Controls.Add(this.steamClearButton, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.steamPathInput, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.steamPathButton, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(438, 29);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // steamClearButton
            // 
            this.steamClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steamClearButton.Location = new System.Drawing.Point(390, 2);
            this.steamClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.steamClearButton.Name = "steamClearButton";
            this.steamClearButton.Size = new System.Drawing.Size(46, 25);
            this.steamClearButton.TabIndex = 2;
            this.steamClearButton.Text = "Reset";
            this.toolTip1.SetToolTip(this.steamClearButton, "This will cause MASGAU to attempt to re-detect Steam.");
            this.steamClearButton.UseVisualStyleBackColor = true;
            this.steamClearButton.Click += new System.EventHandler(this.steamClearButton_Click);
            // 
            // steamPathInput
            // 
            this.steamPathInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steamPathInput.Enabled = false;
            this.steamPathInput.Location = new System.Drawing.Point(3, 4);
            this.steamPathInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.steamPathInput.Name = "steamPathInput";
            this.steamPathInput.Size = new System.Drawing.Size(322, 20);
            this.steamPathInput.TabIndex = 1;
            // 
            // steamPathButton
            // 
            this.steamPathButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steamPathButton.Location = new System.Drawing.Point(330, 2);
            this.steamPathButton.Margin = new System.Windows.Forms.Padding(2);
            this.steamPathButton.Name = "steamPathButton";
            this.steamPathButton.Size = new System.Drawing.Size(56, 25);
            this.steamPathButton.TabIndex = 0;
            this.steamPathButton.Text = "Change";
            this.steamPathButton.UseVisualStyleBackColor = true;
            this.steamPathButton.Click += new System.EventHandler(this.steamPathButton_Click);
            // 
            // groupBox2
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(442, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup Path";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.Controls.Add(this.backupPathInput, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.openBackupPath, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.backupPathButton, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(438, 29);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // backupPathInput
            // 
            this.backupPathInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupPathInput.Enabled = false;
            this.backupPathInput.Location = new System.Drawing.Point(3, 4);
            this.backupPathInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.backupPathInput.Name = "backupPathInput";
            this.backupPathInput.Size = new System.Drawing.Size(322, 20);
            this.backupPathInput.TabIndex = 1;
            // 
            // openBackupPath
            // 
            this.openBackupPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openBackupPath.Enabled = false;
            this.openBackupPath.Location = new System.Drawing.Point(390, 2);
            this.openBackupPath.Margin = new System.Windows.Forms.Padding(2);
            this.openBackupPath.Name = "openBackupPath";
            this.openBackupPath.Size = new System.Drawing.Size(46, 25);
            this.openBackupPath.TabIndex = 2;
            this.openBackupPath.Text = "Open";
            this.openBackupPath.UseVisualStyleBackColor = true;
            this.openBackupPath.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // backupPathButton
            // 
            this.backupPathButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backupPathButton.Location = new System.Drawing.Point(330, 2);
            this.backupPathButton.Margin = new System.Windows.Forms.Padding(2);
            this.backupPathButton.Name = "backupPathButton";
            this.backupPathButton.Size = new System.Drawing.Size(56, 25);
            this.backupPathButton.TabIndex = 0;
            this.backupPathButton.Text = "Change";
            this.backupPathButton.UseVisualStyleBackColor = true;
            this.backupPathButton.Click += new System.EventHandler(this.backupPathButton_Click);
            // 
            // groupBox13
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.groupBox13, 2);
            this.groupBox13.Controls.Add(this.tableLayoutPanel14);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(3, 157);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(440, 1);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Sync Path";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 3;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel14.Controls.Add(this.syncPathInput, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.openSyncPath, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.syncPathButton, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(434, 0);
            this.tableLayoutPanel14.TabIndex = 4;
            // 
            // syncPathInput
            // 
            this.syncPathInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syncPathInput.Enabled = false;
            this.syncPathInput.Location = new System.Drawing.Point(3, 4);
            this.syncPathInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.syncPathInput.Name = "syncPathInput";
            this.syncPathInput.Size = new System.Drawing.Size(318, 20);
            this.syncPathInput.TabIndex = 1;
            // 
            // openSyncPath
            // 
            this.openSyncPath.Enabled = false;
            this.openSyncPath.Location = new System.Drawing.Point(386, 2);
            this.openSyncPath.Margin = new System.Windows.Forms.Padding(2);
            this.openSyncPath.Name = "openSyncPath";
            this.openSyncPath.Size = new System.Drawing.Size(45, 1);
            this.openSyncPath.TabIndex = 2;
            this.openSyncPath.Text = "Open";
            this.openSyncPath.UseVisualStyleBackColor = true;
            this.openSyncPath.Click += new System.EventHandler(this.openSyncPath_Click);
            // 
            // syncPathButton
            // 
            this.syncPathButton.Location = new System.Drawing.Point(326, 2);
            this.syncPathButton.Margin = new System.Windows.Forms.Padding(2);
            this.syncPathButton.Name = "syncPathButton";
            this.syncPathButton.Size = new System.Drawing.Size(56, 1);
            this.syncPathButton.TabIndex = 0;
            this.syncPathButton.Text = "Change";
            this.syncPathButton.UseVisualStyleBackColor = true;
            this.syncPathButton.Click += new System.EventHandler(this.syncPathButton_Click);
            // 
            // autoUpdateCheck
            // 
            this.autoUpdateCheck.AutoSize = true;
            this.autoUpdateCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoUpdateCheck.Location = new System.Drawing.Point(3, 30);
            this.autoUpdateCheck.Name = "autoUpdateCheck";
            this.autoUpdateCheck.Size = new System.Drawing.Size(217, 21);
            this.autoUpdateCheck.TabIndex = 11;
            this.autoUpdateCheck.Text = "Auto-Check For Updates";
            this.autoUpdateCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.autoUpdateCheck.UseVisualStyleBackColor = true;
            this.autoUpdateCheck.CheckedChanged += new System.EventHandler(this.autoUpdateCheck_CheckedChanged);
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.Location = new System.Drawing.Point(226, 30);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(217, 21);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Check For Updates";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.tableLayoutPanel1);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(450, 338);
            this.aboutTab.TabIndex = 4;
            this.aboutTab.Text = "About";
            this.toolTip1.SetToolTip(this.aboutTab, "It totally is");
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox14, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 332);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MASGAU.Properties.Resources._0_8;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 82);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(74)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "MASGAU Automatic Save Game Archive Utility v.0.8";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linkLabel1, 2);
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(74)))), ((int)(((byte)(135)))));
            this.linkLabel1.Location = new System.Drawing.Point(3, 312);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(438, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://masgau.sourceforge.net/";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // groupBox14
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox14, 2);
            this.groupBox14.Controls.Add(this.contributorTree);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(3, 115);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.groupBox14.Size = new System.Drawing.Size(438, 194);
            this.groupBox14.TabIndex = 9;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Contributors";
            // 
            // contributorTree
            // 
            this.contributorTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contributorTree.Location = new System.Drawing.Point(5, 16);
            this.contributorTree.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.contributorTree.Name = "contributorTree";
            this.contributorTree.Size = new System.Drawing.Size(428, 173);
            this.contributorTree.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.ContainerControl = this;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(113, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ShowInTaskbar = true;
            this.progressBar1.Size = new System.Drawing.Size(345, 17);
            this.progressBar1.State = wyDay.Controls.ProgressBarState.Error;
            this.progressBar1.TabIndex = 3;
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // altPathContext
            // 
            this.altPathContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.altPathContext.Name = "altPathContext";
            this.altPathContext.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.toolTip1.SetToolTip(this.button2, "This will cause MASGAU to attempt to re-detect Steam.");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reset";
            this.toolTip1.SetToolTip(this.button3, "This will cause MASGAU to attempt to re-detect Steam.");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // deleteSelectionToolStripMenuItem
            // 
            this.deleteSelectionToolStripMenuItem.Name = "deleteSelectionToolStripMenuItem";
            this.deleteSelectionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteSelectionToolStripMenuItem.Text = "Delete Selection";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "gb7";
            this.saveFileDialog1.Filter = "MASGAU Game Backup|*.gb7";
            this.saveFileDialog1.Title = "Where do you want to save the archive?";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.statusPanel, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.Size = new System.Drawing.Size(460, 383);
            this.tableLayoutPanel11.TabIndex = 8;
            // 
            // statusPanel
            // 
            this.statusPanel.ColumnCount = 2;
            this.statusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.statusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusPanel.Controls.Add(this.progressBar1, 1, 0);
            this.statusPanel.Controls.Add(this.progress_label, 0, 0);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusPanel.Location = new System.Drawing.Point(0, 364);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.statusPanel.RowCount = 1;
            this.statusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.statusPanel.Size = new System.Drawing.Size(460, 19);
            this.statusPanel.TabIndex = 5;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.progress_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress_label.Location = new System.Drawing.Point(3, 0);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(107, 17);
            this.progress_label.TabIndex = 3;
            this.progress_label.Text = "MASGAU Loves you";
            this.progress_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox12
            // 
            this.groupBox12.Location = new System.Drawing.Point(0, 0);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(200, 100);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel12.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel13.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "gb7";
            this.openFileDialog1.Filter = "MASGAU Game Backup|*.gb7";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "What archive(s) do you want to restore?";
            // 
            // masgauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 383);
            this.Controls.Add(this.tableLayoutPanel11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(468, 417);
            this.Name = "masgauForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASGAU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.masgauForm_FormClosing);
            this.Shown += new System.EventHandler(this.masgauForm_Shown);
            this.ResizeBegin += new System.EventHandler(this.masgauForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.masgauForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.masgauForm_Resize);
            this.gamesContext.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.backupTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.restoreTab.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.scheduleTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthDay)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.duplicateCountBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.duplicateCount)).EndInit();
            this.duplicateFrequencyBox.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.duplicateFrequencyNumber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.altPathContext.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage backupTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox steamPathInput;
        private System.Windows.Forms.Button steamPathButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox backupPathInput;
        private System.Windows.Forms.Button backupPathButton;
        private System.Windows.Forms.TabPage restoreTab;
        private System.Windows.Forms.TabPage scheduleTab;
        private System.Windows.Forms.Button steamClearButton;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip restoreContext;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox taskFrequency;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ContextMenuStrip gamesContext;
        private System.Windows.Forms.ContextMenuStrip altPathContext;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button deleteTask;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DateTimePicker timeOfDay;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox weekDay;
        private System.Windows.Forms.NumericUpDown monthDay;
        private System.Windows.Forms.Button openBackupPath;
        private System.Windows.Forms.ListView detectedList;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox taskPassword;
        private System.Windows.Forms.CheckBox dateCheck;
        private System.Windows.Forms.TextBox taskUser;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.CheckBox monitorCheck;
        private System.Windows.Forms.ToolStripMenuItem purgeToolStripMenuItem;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem addPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backThisUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePathToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createArchiveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button taskApply;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel statusPanel;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Button redetectButton;
        private System.Windows.Forms.Button startBackup;
        private System.Windows.Forms.Button backupSelection;
        private wyDay.Controls.Windows7ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.CheckBox versioningCheck;
        private System.Windows.Forms.GroupBox duplicateCountBox;
        private System.Windows.Forms.NumericUpDown duplicateCount;
        private System.Windows.Forms.GroupBox duplicateFrequencyBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.NumericUpDown duplicateFrequencyNumber;
        private System.Windows.Forms.ComboBox duplicateFrequencyCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button removePath;
        private System.Windows.Forms.ListView altPathList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button addPath;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TextBox syncPathInput;
        private System.Windows.Forms.Button openSyncPath;
        private System.Windows.Forms.Button syncPathButton;
        private System.Windows.Forms.CheckBox autoUpdateCheck;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button restoreOtherSaveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button refreshArchivesButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView restoreTree;
        private System.Windows.Forms.ColumnHeader platform;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TreeView contributorTree;
        private System.Windows.Forms.GroupBox groupBox14;
    }
}

