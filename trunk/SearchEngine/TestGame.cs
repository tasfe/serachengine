using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;
using System.Xml.XPath;
namespace SearchEngine
{
	public class TestGame
	{
		Hashtable vistitTable=new Hashtable();
		List<string>taskList=new List<string>();
		List<Thread>threads=new List<Thread>();
		protected int maxThread=10;
		protected int minThread=1;
		protected int currentThread=0;
		protected Thread mainThread;
		public TestGame ()
		{
			this.mainThread=new Thread(new ThreadStart(this.watchThread));
			this.mainThread.Start();
		}
		public void start()
		{
			this.taskList.Add("http://9game.cn");
			Thread one=new Thread(new ThreadStart(run));
			threads.Add(one);
			one.Start();
		}
		private void watchThread()
		{
			while(true)
			{
				List<Thread> removeList=new List<Thread>();
				for(int i=0;i<this.threads.Count;i++)
				{
					Thread one=threads[i];
					if(one.IsAlive)
					{
						
					}
					else
					{
						removeList.Add(one);
					}
				}
				for(int i=0;i<removeList.Count;i++)
				{
					threads.Remove(removeList[i]);
				}
				this.currentThread-=removeList.Count;
				Thread.Sleep(1000);
			}
		}
		private void addTask()
		{
			Thread one=new Thread(new ThreadStart(run));
			threads.Add(one);
			one.Start();
		}
		public void run()
		{
			XmlDocument dom=new XmlDocument();
			WebRequest request;
			while(true)
			{
				if(Thread.CurrentThread.ThreadState.Equals(ThreadState.AbortRequested))
				{
					break;
				}
				Thread.Sleep(1000);
				
			}
			
		}
	}
}

