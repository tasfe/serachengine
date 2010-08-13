package com.search;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.StringReader;
import java.net.URL;

import javax.xml.xpath.XPath;
import javax.xml.xpath.XPathConstants;
import javax.xml.xpath.XPathExpression;
import javax.xml.xpath.XPathFactory;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.w3c.dom.Document;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.w3c.tidy.Tidy;
public class ContentTestCase {
    XPathFactory factory= XPathFactory.newInstance();
    XPath xpath = factory.newXPath();
    XPathExpression linExpr;
	Tidy tidy=new Tidy();
	BufferedReader reader;
	String content;
	URL url;
	@Before
	public void setUp() throws Exception {
		url=new URL("http://www.163.com");
		StringBuffer buffer=new StringBuffer();
		reader=new BufferedReader(new InputStreamReader(url.openStream()));
		String line=reader.readLine();
		this.linExpr = xpath.compile("//a[@href]/@href");
		while(line!=null)
		{
			buffer.append(line);
		line=reader.readLine();
		}
	content=buffer.toString();
	System.out.println("初始化完成:"+content.length()/1024);
	}

	@After
	public void tearDown() throws Exception {
	}
	@Test
	public void testContent()
	{
		long begin=System.currentTimeMillis();
		
		try {
			//URL client=new URL("http://www.163.com");
			StringReader read=new StringReader(content);
			tidy.setShowWarnings(false);
			tidy.setShowErrors(0);
			tidy.setQuiet(true);
			tidy.setXHTML(true);
			tidy.setXmlOut(true);
			Document dom=tidy.parseDOM(read, null);
		    NodeList list=dom.getChildNodes();
		    System.out.print(list.getLength());
		    Object result = this.linExpr.evaluate(dom, XPathConstants.NODESET);
		    NodeList nodes = (NodeList) result;
		    System.out.println(nodes.getLength());
		} catch (Exception e) {
			// TODO Auto-generated catch block
			System.err.println("出现错误");
			e.printStackTrace();
		}
		System.out.println(System.currentTimeMillis()-begin);
		
	}

}
