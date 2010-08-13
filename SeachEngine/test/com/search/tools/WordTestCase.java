package com.search.tools;

import java.io.BufferedWriter;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.io.OutputStreamWriter;

import junit.framework.TestCase;

import org.apache.poi.hwpf.HWPFDocument;
import org.apache.poi.hwpf.extractor.WordExtractor;
import org.apache.poi.poifs.filesystem.POIFSFileSystem;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
/**
 * 测试word的功能
 * @author Administrator
 *
 */
public class WordTestCase extends TestCase{

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}
	@Test
	public void testGetText()
	{
		try
		{
		InputStream inp = new FileInputStream("D:\\下载教程\\2008.doc");
		HWPFDocument wb = new HWPFDocument(new POIFSFileSystem(inp));
		BufferedWriter writer=new BufferedWriter(new OutputStreamWriter(new FileOutputStream("c:\\out.txt")));
		WordExtractor extractor = new WordExtractor(wb);
      	String text = extractor.getText();
      	writer.write(text);
      	writer.close();
      	//System.out.println(text);
		}
		catch(Exception e)
		{
			System.out.println(e);
		}

		
	}

}
