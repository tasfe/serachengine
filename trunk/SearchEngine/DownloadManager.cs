
using System;
using System.Collections;
using System.Collections.Specialized;
namespace SearchEngine
{

	/// <summary>
	/// 管理文件的下载
	/// </summary>
	public class DownloadManager
	{

		protected ArrayList taskList;
		public DownloadManager ()
		{
			this.taskList=new ArrayList();
		}
		public void add(String url)
		{
			lock(this)
			{
				this.taskList.Add(url);
				
			}
		}
	}
}
