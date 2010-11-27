using System;
namespace SearchEngine
{
	public class JSON
	{
		protected int current;
		protected int length;
		protected string source;
		public JSON ()
		{
			
		}
		/// <summary>
		/// 读取数字
		/// </summary>
		/// <returns>
		/// A <see cref="JSONNumber"/>
		/// </returns>
		public JSONNumber readNumber()
		{
			return null;
		}
		public string readString()
		{
			return null;
		}
		protected char readNext()
		{
			return 'a';
		}
		protected bool readTrue()
		{
			return true;
		}
		protected bool readFalse()
		{
			return false;
		}
		protected void readNull()
		{
			
		}
		protected void unGet()
		{
			
		}
		protected bool eof()
		{
			return false;
		}
		public JSONArray readArray()
		{
			return null;
			
		}
		public JSONObject readObject()
		{
			//get{
			while(!eof())
			{
				char ch=readNext();
				if(!char.IsWhiteSpace(ch))
				{
					if(ch=='{')
					{
						break;
					}
					else
					{
					throw new JSONException("错误的开始{");	
					}
				}
				 
			}
			while(!eof())
			{
			//getkey
			while(!eof())
			{
				string key=readString();
			}
			//:
			while(!eof())
			{
				char ch=readNext();
				if(!char.IsWhiteSpace(ch))
				{
					if(ch==':')
						{
							
						}
					else
						{
							
						}
				}
			
			}
				//getvalue
			while(!eof())
				{
					char ch=readNext();
				    if(!char.IsWhiteSpace(ch))
					{
						switch(ch)
						{
						case '[':break;
						case '{':break;
						case '}':break;
						case ',':break;
						}
					}
				}
			
			}
			return null;
		}
		public string stringify(Object obj)
		{
			return null;
		}
		public JSONObject parse(string source)
		{
			this.source=source;
			this.length=source.Length;
			this.current=0;
			return readObject();
		}
	}
}
