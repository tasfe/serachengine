using System;
using System.Collections.Generic;
using System.Collections;
namespace SearchEngine
{
	/// <summary>
	/// 
	/// </summary>
	public class DnsCache
	{
		public class DnsItem
		{
			public string name;
			public string address;
			public DateTime lastupdate;
		}
		protected List<DnsCache.DnsItem>dnsList=new List<DnsItem>(); 
		public DnsCache ()
		{
		}
	}
}

