
using System;
using System.Xml;
using  System.Xml.XPath;
namespace SearchEngine
{


	public class ControlParser
	{

		XmlDocument document;
		public ControlParser ()
		{
			document=new XmlDocument();
		}
		public void parse(String file)
		{
			document.Load(new System.IO.StreamReader(file));
			XmlElement root= document.DocumentElement;
			
			
		}
	}
}
