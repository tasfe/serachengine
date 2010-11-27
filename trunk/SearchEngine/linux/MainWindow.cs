using System;
using Microsoft.Win32;
using Gtk;
namespace SearchEngine.linux
{
	public partial class MainWindow : Gtk.Window
	{
		private void powerEvent(object obj,PowerModeChangedEventArgs arg)
		{
			
		}
		private void sessionEndingEvent(object obj,SessionEndingEventArgs arg)
		{
			MessageDialog md = new MessageDialog (this, 
                                      DialogFlags.DestroyWithParent,
	                              MessageType.Question, 
                                      ButtonsType.YesNo, "Are you sure you want to quit?");
	
ResponseType result = (ResponseType)md.Run ();

if (result == ResponseType.Yes)
arg.Cancel=false;
else
			{
				arg.Cancel=true;
	md.Destroy();}
md.Destroy();
		}
		public MainWindow () : base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			SystemEvents.PowerModeChanged+=new PowerModeChangedEventHandler(powerEvent);
			SystemEvents.SessionEnding+=new SessionEndingEventHandler(sessionEndingEvent);
		}
		protected override bool OnDestroyEvent (Gdk.Event evnt)
		{
			return base.OnDestroyEvent (evnt);
		}
			                                                                
	}
}

