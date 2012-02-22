
// This file has been generated by the GUI designer. Do not modify.
namespace MASGAU.Analyzer
{
	public partial class ReportDialog
	{
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView reportText;
		private global::Gtk.Label disclaimerLabel;
		private global::Gtk.Button saveButton;
		private global::Gtk.Button uploadButton;
		private global::Gtk.Button closebutton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MASGAU.Analyzer.ReportDialog
			this.Name = "MASGAU.Analyzer.ReportDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MASGAU.Analyzer.ReportDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.reportText = new global::Gtk.TextView ();
			this.reportText.CanFocus = true;
			this.reportText.Name = "reportText";
			this.GtkScrolledWindow.Add (this.reportText);
			w1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1 [this.GtkScrolledWindow]));
			w3.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.disclaimerLabel = new global::Gtk.Label ();
			this.disclaimerLabel.Name = "disclaimerLabel";
			this.disclaimerLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.disclaimerLabel.Wrap = true;
			w1.Add (this.disclaimerLabel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.disclaimerLabel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Internal child MASGAU.Analyzer.ReportDialog.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "dialog1_ActionArea";
			w5.Spacing = 10;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.saveButton = new global::Gtk.Button ();
			this.saveButton.CanDefault = true;
			this.saveButton.CanFocus = true;
			this.saveButton.Name = "saveButton";
			this.saveButton.UseStock = true;
			this.saveButton.UseUnderline = true;
			this.saveButton.Label = "gtk-save";
			this.AddActionWidget (this.saveButton, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.saveButton]));
			w6.Expand = false;
			w6.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.uploadButton = new global::Gtk.Button ();
			this.uploadButton.Sensitive = false;
			this.uploadButton.CanDefault = true;
			this.uploadButton.CanFocus = true;
			this.uploadButton.Name = "uploadButton";
			this.uploadButton.UseUnderline = true;
			// Container child uploadButton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w7 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w8 = new global::Gtk.HBox ();
			w8.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-up", global::Gtk.IconSize.Menu);
			w8.Add (w9);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w11 = new global::Gtk.Label ();
			w11.LabelProp = global::Mono.Unix.Catalog.GetString ("_Upload");
			w11.UseUnderline = true;
			w8.Add (w11);
			w7.Add (w8);
			this.uploadButton.Add (w7);
			this.AddActionWidget (this.uploadButton, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.uploadButton]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.closebutton = new global::Gtk.Button ();
			this.closebutton.CanFocus = true;
			this.closebutton.Name = "closebutton";
			this.closebutton.UseStock = true;
			this.closebutton.UseUnderline = true;
			this.closebutton.Label = "gtk-close";
			this.AddActionWidget (this.closebutton, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.closebutton]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 399;
			this.DefaultHeight = 310;
			this.Show ();
			this.saveButton.Clicked += new global::System.EventHandler (this.OnSaveButtonClicked);
			this.uploadButton.Clicked += new global::System.EventHandler (this.OnUploadButtonClicked);
		}
	}
}