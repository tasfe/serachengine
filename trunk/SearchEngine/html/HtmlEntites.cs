
using System;
using System.Collections;
using System.Collections.Generic;
namespace SearchEngine
{


	/// <summary>
	/// 实体名称
	/// &entity_name;
    ///&#entity_number;
	/// </summary>
	public class HtmlEntites
	{
		protected static Hashtable entitesTable;
		static HtmlEntites()
		{
			
			entitesTable=new Hashtable();
			entitesTable["&lt;"]="<";
			entitesTable["&gt;"]=">";
			entitesTable["&amp;"]="&";
			entitesTable["&apos;"]="'";
			entitesTable["&quot;"]="\"";
		}
		public string this[string key]
		{
			get
			{
				return (String)entitesTable[key];
			}
		}
		public HtmlEntites ()
		{
		}
	}
}
