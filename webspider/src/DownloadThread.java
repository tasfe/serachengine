import java.io.*;
import java.net.*;
import java.util.*;

import org.w3c.dom.Document;
import org.w3c.dom.NodeList;
import org.w3c.tidy.Tidy;
import javax.xml.xpath.XPath;
import javax.xml.xpath.XPathConstants;
import javax.xml.xpath.XPathExpression;
import javax.xml.xpath.XPathFactory;
public class DownloadThread implements Runnable{
	protected ArrayList<String> urllist;
	protected URL url;
	protected XPathExpression expr;
	public DownloadThread()
	{
		this.urllist=new ArrayList<String>();
	}
	public synchronized void addUrl(String url)
	{
		this.urllist.add(url);
	}
	protected void getLinker(InputStream in)
	{
		try
		{
		long begin=System.currentTimeMillis();
		StringBuffer buffer=new StringBuffer();
		XPath xpath= XPathFactory.newInstance().newXPath();
		expr=xpath.compile("//a[@href]/@href");
		Tidy tidy=new Tidy();
		tidy.setXHTML(true);
		tidy.setShowWarnings(false);
		Document dom=tidy.parseDOM(url.openStream(), null);
		Object obj=expr.evaluate(dom, XPathConstants.NODESET);
		NodeList nodes = (NodeList) obj;
		
		for (int i = 0; i < nodes.getLength(); i++) {
		   buffer.append(nodes.item(i).getNodeValue()+"<br/>"); 
		}
		long end=System.currentTimeMillis();
		buffer.append("waste:"+(end-begin)+"ms\r\n");
		OutputManager.get().wirte(buffer.toString());
		}
		catch(Exception e)
		{
			e.printStackTrace();
		}
		
		
	}
	@Override
	public void run() {
		// TODO Auto-generated method stub
		for(int i=0;i<urllist.size();i++)
		{
			try
			{
				url=new URL(urllist.get(i));
				getLinker(url.openStream());
			}
			catch(Exception e)
			{
				e.printStackTrace();
			}
		}
		
	}

}
