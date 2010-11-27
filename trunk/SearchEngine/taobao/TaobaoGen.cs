using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom;
using Microsoft.CSharp;
using System.IO;
using System.Net;
using System.Net.Sockets;
using HtmlAgilityPack;
using System.Threading;
using System.Xml;
using System.Xml.XPath;
using System.CodeDom.Compiler;
namespace SearchEngine
{
	public class TaobaoGen
	{
	
		CodeNamespace taobao;
		CSharpCodeProvider csharp;
		HtmlDocument dom;
		Thread thread;
		Dictionary<string,string> typeMap;
		List<string>firstMenu;
		List<string>secondMenu;
		public TaobaoGen ()
		{
			dom=new HtmlDocument();
			thread=new Thread(new ThreadStart(run));
			typeMap=new Dictionary<string, string>();
			firstMenu=new List<string>();
			secondMenu=new List<string>();
			taobao=new CodeNamespace("Taobao");
		}
		protected void init()
		{
			this.csharp=new CSharpCodeProvider();
			this.taobao.Imports.Add(new CodeNamespaceImport("System"));
		}
		protected void writeCode()
		{
			CodeGeneratorOptions options=new CodeGeneratorOptions();
			
			this.csharp.GenerateCodeFromNamespace(this.taobao,new StreamWriter("/home/jian/taobao.cs"),options);
		}
		public void start()
		{
			
				thread.Start();
			Console.WriteLine("task begin");
			
		}
		public void run()
		{
			dom.Load(WebRequest.Create("http://my.open.taobao.com/apidoc/index.htm").GetResponse().GetResponseStream());
			foreach(XPathNavigator node in dom.CreateNavigator().Select("//div[@id='api-type-wrap']//li/a/@href"))
			{
				Console.WriteLine("value:"+node.Value);
				firstMenu.Add("http://my.open.taobao.com/apidoc/content.htm?path="+node.Value.Replace("#",""));
			}
			StreamWriter writer=new StreamWriter("/home/jian/taobao.list");
			foreach(string value in firstMenu)
			{
				writer.WriteLine(value);
				dom.Load(WebRequest.Create(value).GetResponse().GetResponseStream());
				foreach(XPathNavigator node in dom.CreateNavigator().Select("//table[@class='para_table']//tr/td//a"))
				{
					typeMap.Add(node.Value,"http://my.open.taobao.com/apidoc/content.htm?path="+node.GetAttribute("href",null).Replace("#",""));
				}
			}
			writer.Close();
			
			foreach(string key in typeMap.Keys)
			{
				if(key.IndexOf(',')>0)
				{
					
				}
				else
				{
					dom.Load(WebRequest.Create(typeMap[key]).GetResponse().GetResponseStream());
					foreach(XPathNavigator node in dom.CreateNavigator().Select("//table[@class='para_table']/tr[position()>1]"))
					{
						string name=node.SelectSingleNode("//td[1]//text()").Value;
						string type=node.SelectSingleNode("//td[2]//text()").Value;
						if(typeMap.ContainsKey(type))
						{
							XPathNavigator  link=node.SelectSingleNode("//td[2]//a/@href");
							if(link!=null)
							{
								typeMap.Add(type,"http://my.open.taobao.com/apidoc/content.htm?path="+link.Value.Replace("#",""));
							}
						}
					}
				}
			
				
			}
				writer=new StreamWriter("/home/jian/taobao.map");
			foreach(string key in typeMap.Keys)
			{
				writer.WriteLine(key+":"+typeMap[key]);
				
			}
			writer.Close();
		}
		public void stop()
		{
			thread.Interrupt();
		}
	}
}

