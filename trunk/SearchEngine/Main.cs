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
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Security.Cryptography;
using HtmlAgilityPack;
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
		/// Windows show window
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
			//MessageBox.Show(Assembly.GetEntryAssembly().FullName);
		    init();
			
			
		  
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
