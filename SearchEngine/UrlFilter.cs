
using System;
using System.Text.RegularExpressions;
namespace SearchEngine
{

	/// <summary>
	/// 网址过滤器
	/// </summary>
	public class UrlFilter:Attribute
	{

		/// <summary>
		/// 过滤字符串
		/// </summary>
		public String filter;
		public UrlFilter ()
		{
			
		}
	}
}
