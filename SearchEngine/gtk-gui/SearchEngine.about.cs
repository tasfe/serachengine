
// This file has been generated by the GUI designer. Do not modify.
namespace SearchEngine
{
	public partial class about
	{
		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget SearchEngine.about
			this.Name = "SearchEngine.about";
			this.Title = global::Mono.Unix.Catalog.GetString ("dialog1");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child SearchEngine.about.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Internal child SearchEngine.about.ActionArea
			global::Gtk.HButtonBox w2 = this.ActionArea;
			w2.Name = "dialog1_ActionArea";
			w2.Spacing = 10;
			w2.BorderWidth = ((uint)(5));
			w2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w3 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w2[this.buttonCancel]));
			w3.Expand = false;
			w3.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w2[this.buttonOk]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}
