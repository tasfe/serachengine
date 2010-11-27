using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Security;
using System.Reflection;
using System.Diagnostics;
using System.Xml;
using System.Xml.XPath;
using System.Security.Principal;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
namespace SearchEngine
{
	/// <summary>
	/// the main class startup class
	/// </summary>
	partial class MainClass
	{
		static MainClass()
		{
			Console.WriteLine("begin init application");
			//Trace.WriteLine("begin init application");
			//Debug.WriteLine("begin init application");
		}
		/// <summary>
		/// begin init application
		/// </summary>
		static void init()
		{
			AppDomain.CurrentDomain.UnhandledException+=new UnhandledExceptionEventHandler(domain_Exception);
			string userName=Environment.UserName;
			Console.WriteLine(userName);
			int cpuCount=Environment.ProcessorCount;
			Console.WriteLine(cpuCount);
			string userFolder=Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			Console.WriteLine(userFolder);
			switch(Environment.OSVersion.Platform)
			{
			case PlatformID.MacOSX:startForm();break;
			case PlatformID.Unix:startGtk();break;
			case PlatformID.Win32NT:startForm();break;
			case PlatformID.Win32S:startForm();break;
			case PlatformID.Win32Windows:startForm();break;
			case PlatformID.WinCE:startForm();break;
			case PlatformID.Xbox:startForm();break;
			default:break;
			}
			
		}
		/// <summary>
		/// 
		/// </summary>
		static void startForm()
		{
			Application.EnableVisualStyles();
			Application.Run(new Form());
			
		}
		
	    /// <summary>
	    /// 主启动函数
	    /// </summary>
	    /// <param name="args">
	    /// A <see cref="System.String[]"/>
	    /// </param>
		public static void Main(string[] args)
		{
		CodeCompileUnit targetUnit = new CodeCompileUnit();
    CodeNamespace samples = new CodeNamespace("CodeDOMSample");
    samples.Imports.Add(new CodeNamespaceImport("System"));
    CodeTypeDeclaration targetClass = new CodeTypeDeclaration("CodeDOMCreatedClass");
    targetClass.IsClass = true;
    targetClass.TypeAttributes =
        TypeAttributes.Public | TypeAttributes.Sealed;
    samples.Types.Add(targetClass);
    targetUnit.Namespaces.Add(samples);
			CodeMemberField widthValueField = new CodeMemberField();
    widthValueField.Attributes = MemberAttributes.Private;
    widthValueField.Name = "widthValue";
    widthValueField.Type = new CodeTypeReference(typeof(System.Double));
    widthValueField.Comments.Add(new CodeCommentStatement(
        "The width of the object."));
    targetClass.Members.Add(widthValueField);

    // Declare the heightValue field
    CodeMemberField heightValueField = new CodeMemberField();
    heightValueField.Attributes = MemberAttributes.Private;
    heightValueField.Name = "heightValue";
    heightValueField.Type =
        new CodeTypeReference(typeof(System.Double));
    heightValueField.Comments.Add(new CodeCommentStatement(
        "The height of the object."));
    targetClass.Members.Add(heightValueField);
			CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
    CodeGeneratorOptions options = new CodeGeneratorOptions();
    options.BracingStyle = "C";
    using (StreamWriter sourceWriter = new StreamWriter("/home/jian/taobao.cs"))
    {
        provider.GenerateCodeFromCompileUnit(
            targetUnit, sourceWriter, options);
    }
		}
		
			
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender">
		/// A <see cref="System.Object"/>
		/// </param>
		/// <param name="args">
		/// A <see cref="UnhandledExceptionEventArgs"/>
		/// </param>
		static void domain_Exception(object sender, UnhandledExceptionEventArgs args)
		{
			Console.WriteLine("error happen system exit now");
			Application.Exit();
		}
	}
}
/*
 * if(debug)
			{
				Console.WriteLine("cpu count:"+cpuCount);
			}
			
			if(debug)
			{
				Console.WriteLine(userFolder);
			}
			
			Stack stack=new Stack();
			Hashtable table=new Hashtable();
			stack.Push(Assembly.GetExecutingAssembly().GetName());
			table[Assembly.GetExecutingAssembly().GetName().FullName]=true;
			while(stack.Count>0)
			{
				AssemblyName name=(AssemblyName)stack.Pop();
				Assembly asm=Assembly.Load(name);
				foreach(AssemblyName na in asm.GetReferencedAssemblies())
				{
					if(table.ContainsKey(na.FullName))
					{
						//Console.WriteLine("find:"+na.FullName);
					}
					else{stack.Push(na);table[na.FullName]=true;}
				}
				Console.WriteLine(name.FullName);
			}
			Console.WriteLine(Environment.UserName);
			Console.WriteLine(Environment.OSVersion.Platform.ToString());
			/*PermissionSet set=new PermissionSet(PermissionState.None);
			 set.AddPermission(
                new EnvironmentPermission(Env):ironmentPermissionAccess.Read, "USERNAME"));
			set.Demand();
			System.Windows.Forms.MessageBox.Show(Environment.OSVersion.ToString());
			*/
			//AppDomain.CreateDomain(
			//AppDomain.CreateDomain(
			//AppDomain.CurrentDomain
			//Application.EnableVisualStyles();
			//Application.Run(new FormMain());
			//HtmlDocument dom=new HtmlDocument();
			//HttpWebRequest request=(HttpWebRequest)WebRequest.Create("http://taobao.com");
			//HttpWebResponse response=(HttpWebResponse)request.GetResponse();
			//WebClient client=new WebClient();
			//StreamReader reader=new StreamReader(client.OpenRead("http://my.open.taobao.com/apidoc/content.htm?path=categoryId:1-dataStructId:2"));
			//String content=reader.ReadToEnd();
			//Console.WriteLine(content);
			//Console.WriteLine("reader over");
			//dom.Load(response.GetResponseStream());
			//dom.LoadHtml(content);
			//dom.Load("http://my.open.taobao.com/apidoc/content.htm?path=categoryId:1-dataStructId:2");
			//XslCompiledTransform xslt=new XslCompiledTransform();
			//xslt.Load("/home/jian/taobao.xsl");
			//Console.WriteLine(dom.CreateNavigator);
			//dom.t
              /*有参数处理参数问题
			if(args.Length>0)
			{
				
				//XmlDocument document=new XmlDocument();
		
			}
			else
			{
				Console.WriteLine("----欢迎使用搜索引擎的测试版本----");
				Console.WriteLine("----本实例为测试应用实现----");
					   
				
			}
			
			/*try{
			ArrayList urls=new ArrayList();
			HtmlDocument document=new HtmlDocument();
		    HttpWebRequest request=(HttpWebRequest)WebRequest.Create("http://www.chinesebibleonline.com/");
			HttpWebResponse response=(HttpWebResponse)request.GetResponse();
			StreamReader reader=new StreamReader(response.GetResponseStream(),Encoding.GetEncoding("gbk"));
			String content=reader.ReadToEnd();
			document.LoadHtml(content);
			XPathNodeIterator nodes=document.CreateNavigator().Select("//td[@class='td_ind']/a[@href]");
			XPathNodeIterator links=document.CreateNavigator().Select("//td[@class='td_ind']/a[@href]/@href");
			XPathNodeIterator noedsNum=document.CreateNavigator().Select("//td[@align='right']/text()");
			Console.WriteLine(nodes.Count);	
				ArrayList linkList=new ArrayList();
			foreach(XPathNavigator node in nodes)
			{
							
			urls.Add(node.Value);
			linkList.Add(node.GetAttribute("href",null));
					
					
			}
				
		
			ArrayList numlist=new ArrayList();
				Console.WriteLine(noedsNum.Count);
			foreach(XPathNavigator node in noedsNum)
			{
							
			numlist.Add(node.ValueAsInt);
					
					
			}
			for(int i=0;i<urls.Count;i=i+3)
			{
			
					Task task1=new Task();
					for(int j=0;j<3;j++)
					{
					task1.name=(String)urls[i+j];
					task1.count=(int)numlist[i+j];
					task1.path=(String)linkList[i+j];
					MainClass main=new MainClass(task1);
					Thread one=new Thread(new ThreadStart(main.run));
					one.Start();
						one.Join();
					}
					
			}
			
		//Console.WriteLine(getNodeValue(document.CreateNavigator()));
				
					
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			*/
 /* //HttpWebRequest request=(HttpWebRequest)WebRequest.Create("");
			Uri url=new Uri("http://baidu.com/q?a=d&b=c#aa");
			//Console.WriteLine(url.Host);
			//Console.WriteLine(url.Port);
			//Console.WriteLine(url.PathAndQuery);
			//Console.WriteLine(url.LocalPath);
			//Hashtable table=new Hashtable();
			try{
		    
			WebClient client=new WebClient();
			HtmlDocument document=new HtmlDocument();
				Uri url1=new Uri("http://open.taobao.com/dev/index.php/API2.0:User");
			document.Load(client.OpenRead(url1));
		    XPathNodeIterator nodes=document.CreateNavigator().Select("//table[@class='para_table']");
			Console.WriteLine(nodes.Count);
				foreach(XPathNavigator node in nodes)
				{
					foreach (XPathNavigator node1 in node.Select("//tr/td/text()"))
					{
						Console.WriteLine("结果:"+node1.TypedValue);
					}
					
				}
					
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
 */