
using System;
using System.Collections;
using System.Collections.Specialized;
namespace SearchEngine
{

	/// <summary>
	/// 访问的历史记录查询
	/// </summary>
	public class HistoryManager
	{
		protected Hashtable historyTable;

		public HistoryManager ()
		{
			this.historyTable=new Hashtable();
		}
	}
}
