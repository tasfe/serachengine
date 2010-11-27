
using System;
using System.Windows.Forms;
namespace SearchEngine
{


	public class FormMain:Form
	{
		

		public FormMain ():base()
		{
		this.Visible=true;
		FlowLayoutPanel panel=new FlowLayoutPanel();
		WebBrowser browser=new WebBrowser();
		panel.Dock=DockStyle.Fill;
		this.Controls.Add(panel);
			for(int i=0;i<10;i++)
			{
				Button one=new Button();
				one.Text="hello"+i;
				panel.Controls.Add(one);
			}
			panel.Controls.Add(browser);
			browser.Navigate("http://baidu.com");
			MenuStrip men=new MenuStrip();
			this.Controls.Add(men);
			men.Dock=DockStyle.Top;
			
		}
	}
}
