using System;
using Gtk;
using SearchEngine.linux;
using System.Reflection;
using System.Security.Cryptography;
namespace SearchEngine
{
	partial class MainClass
	{
		static DSACryptoServiceProvider dsa;
		static RSACryptoServiceProvider rsa;
		static bool isGtkFirstRun()
		{
			return true;
		}
		/// <summary>
		/// 
		/// </summary>
		static void initGtk()
		{
			if(isGtkFirstRun())
			{
				Assembly asm=Assembly.GetExecutingAssembly();
			    foreach(AssemblyName name in asm.GetReferencedAssemblies())
				{
					//name.CodeBase;
					
				}
			}
		}
		static void startGtk()
		{
			Application.Init();
			MainWindow mainWindow=new MainWindow();
			mainWindow.Show();
			about a=new about();
			a.Show();
			Application.Run();
		}
	}
}
