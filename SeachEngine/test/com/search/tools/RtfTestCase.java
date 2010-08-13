package com.search.tools;


import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;

import javax.swing.text.BadLocationException;
import javax.swing.text.DefaultStyledDocument;
import javax.swing.text.Element;
import javax.swing.text.rtf.RTFEditorKit;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
public class RtfTestCase {

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}
	@Test
	public void testRtf()
	{
		DefaultStyledDocument document=new DefaultStyledDocument();
		Element root=document.getDefaultRootElement();
		RTFEditorKit kit=new RTFEditorKit(); 
		try {
			kit.read(new InputStreamReader(new FileInputStream("C:\\Documents and Settings\\Administrator\\×ÀÃæ\\Doc1.rtf"),"gb2312"), document, 0);
			System.out.println(document.getText(0, document.getLength()));
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (BadLocationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	
	}

}
