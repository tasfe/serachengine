
using System;
using System.Xml;
using System.Collections.Generic;
using System.Collections;
using System.Text;
namespace SearchEngine
{


	/// <summary>
	/// 解析html文档
	/// </summary>
	public class HtmlParser
	{
		protected static  Hashtable entityMap;
		protected static readonly int Tag_Begin=0;
		protected static readonly int Tag_End=1;
		protected int lineNo=1;
		protected int colNo=1;
		protected string source;
		protected int current=0;
		protected XmlDocument document;
		protected XmlAttribute attribute;
		 static HtmlParser()
		{
			entityMap=new Hashtable();
		}
		public HtmlParser ()
		{
			this.document=new XmlDocument();
			
		}
		/// <summary>
		/// 解析html
		/// </summary>
		/// <param name="url">
		/// A <see cref="Uri"/>
		/// </param>
		/// <returns>
		/// A <see cref="XmlDocument"/>
		/// </returns>
		public XmlDocument parse(Uri url)
		{
			if(url.IsFile)
			{
				
			}
			else
			{
				
			}
			return null;
		}
		#region 
		protected XmlText createTextElement(String text)
		{
			return document.CreateTextNode(text);
		}
		protected XmlElement createElement(String tagNme)
		{
			return null;
		}
		protected XmlElement createCDataElement(String text)
		{
			document.CreateCDataSection(text);
			return null;
		}
		/// <summary>
		/// create comment element
		/// </summary>
		/// <param name="text">
		/// A <see cref="String"/>
		/// </param>
		/// <returns>
		/// A <see cref="XmlElement"/>
		/// </returns>
		protected XmlComment createComment(String text)
		{
			return document.CreateComment(text);
			
		}
		#endregion
		/// <summary>
		/// 解析html返回dom结构数据
		/// </summary>
		/// <returns>
		/// A <see cref="XmlDocument"/>
		/// </returns>
		private XmlDocument parse()
		{   while(!eof())
			{   char ch=getNext();
				switch(ch)
				{
				case '<':
				{
					char ch2=getNext();
					if(char.IsWhiteSpace(ch2))
					{
						
					}
					else{
						switch(ch2)
						{
						case '?':break;
						case '!':break;
						case'%':break;
						default:break;
						}
					}
					break;
				}
				case '>':break;
				case '&':break;
				case ':':break;
				case '/':break;
				case '?':break;
				case '!':break;
				default:break;
				}
				
			}
			return null;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// A <see cref="String"/>
		/// </returns>
		protected String getTextNode()
		{
			//<
			return null;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// A <see cref="String"/>
		/// </returns>
		protected String getAttributeName()
		{
			return null;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// A <see cref="String"/>
		/// </returns>
		protected String getAttributeValue()
		{	//" "|''|space|>		
			return null;
		}
		/// <summary>
		/// 得到标签的名称
		/// Tag_End  > space
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		protected string getTagName()
		{
			
			//StringBuffer buffer=new StringBuffer();
			//StringBuffer sourceBuffer=new StringBuffer();
			while(!eof())
			{
				char ch=getNext();
				switch(ch)
				{
				case ' ':break;
				case '>':break;
				default://buffer.append(ch);
					break;
				}
			}
			return null;
		}
		/// <summary>
		/// 得到注释数据<!-- -->
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		protected string getComment()
		{
			//-->
			StringBuilder buffer=new StringBuilder();
			return null;
		}
		/// <summary>
		/// 得到cdata数据 <![CDATA[ ]]>
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/>
		/// </returns>
		protected string getCDATA()
		{
			//]]>
			StringBuilder buffer=new StringBuilder();
			StringBuilder endBuffer=new StringBuilder();
			return null;
		}
		/// <summary>
		/// 得到属性
		/// </summary>
		/// <returns>
		/// A <see cref="Hashtable"/>
		/// </returns>
		protected Hashtable getAttribute()
		{
			Hashtable table=new Hashtable();
			return null;
		}
		/// <summary>
		/// 得到下一个字符
		/// </summary>
		/// <returns>
		/// A <see cref="System.Char"/>
		/// </returns>
		protected char getNext()
		{
			while(!eof())
			{
			char ch=source[current++];
			if(ch=='\n')
			{
				lineNo++;
			}
			else
			{
				colNo++;
			}
			return ch;
			}
			return default(char);
		}
		/// <summary>
		/// 返回当前字符
		/// </summary>
		protected void unget()
		{
			if(current>0)
			{
			current--;
			}
		}
		/// <summary>
		/// 得到下一个非ch字符
		/// </summary>
		/// <param name="ch">
		/// A <see cref="System.Char"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Char"/>
		/// </returns>
		protected char getNext(char ch)
		{
			return 'a';
			while(!eof())
			{
				char cha=source[current++];
				if(cha!=ch)
				{
					return cha;
				}
			}
		}
		/// <summary>
		/// 判断是否达到结尾
		/// </summary>
		/// <returns>
		/// A <see cref="System.Boolean"/>
		/// </returns>
		protected bool eof()
		{
			if(current>=source.Length)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
	}
}
