
using System;
using System.Threading;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace SearchEngine
{
	/// <summary>
	/// 下载线程处理文件
	/// </summary>
	public class DownloadThread
	{
		ArrayList tasklist;
		int currentPos;
		HttpWebRequest request;
		HttpWebResponse response;
		Boolean STOP=false;
		
		public DownloadThread()
		{
			tasklist=new ArrayList();
			//tasklist.Sort();
		}
		public void addTask(String url)
		{
			lock(tasklist)
			{
				this.tasklist.Add(url);
				
			}
		}
		protected void run()
		{
			while(true)
			{
				if(STOP)
				{
					this.onExit();
					break;
				}
				else
				{
					if(this.currentPos>=this.tasklist.Count)
					{
						Thread.Sleep(1000);
						Console.WriteLine("无任务下载");
					}
					else
					{
						
					}
					
				}
			}
		}
		protected void getContent(String url)
		{
			Uri weburl=new Uri(url);
			request=(HttpWebRequest)WebRequest.Create(weburl);
			this.response=(HttpWebResponse)request.GetResponse();
			Stream stream=this.response.GetResponseStream();
			
		}
		public void start()
		{
			
		}
		public void stop()
		{
			this.STOP=true;
		}
		public void onExit()
		{
			Console.WriteLine("本线程退出");
		}
	}
}
