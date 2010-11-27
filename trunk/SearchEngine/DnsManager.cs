
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
namespace SearchEngine
{


	public class DnsManager
	{
		protected Hashtable ipTable;
		protected BinaryReader reader;
		protected BinaryWriter writer;
		public DnsManager ()
		{
			this.ipTable=new Hashtable();
		}
		/// <summary>
		/// 查询一个ip的地址
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/>
		/// </param>
		/// <returns>
		/// A <see cref="String"/>
		/// </returns>
		public String getAddress(String name)
		{
		   Regex ipRegex=new Regex(@"(\d+\.){4}");
			//Dns.GetHostAddresses(name)[0].ToString()
			return null;
			
		}
		/// <summary>
		/// 保存地址(已经使用的地址)
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/>
		/// </param>
		public void save(String path)
		{
			try
			{
			this.writer=new BinaryWriter(File.OpenWrite(path));
			foreach(String key in this.ipTable.Keys)
			{
			this.writer.Write(key);
			this.writer.Write((String)ipTable[key]);
			}
			}
			catch(Exception ex)
			{
				
			}
		}
		
	}
}
