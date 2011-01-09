using System;
namespace SearchEngine
{
	public partial class ConfigView : Gtk.Window
	{
		public ConfigView () : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

