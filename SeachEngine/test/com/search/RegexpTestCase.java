package com.search;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import junit.framework.TestCase;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
/**
 * 正则表达式的测试
 * @author my123jian@gmail.com
 *
 */
public class RegexpTestCase extends TestCase{

	BufferedReader reader;
	ArrayList<Pattern> patternList;
	ArrayList<String> testList;
	@Before
	public void setUp() throws Exception {
		String fileName="c:\\regexp.txt";
		boolean isTest=false;
		testList=new ArrayList<String>();
		patternList=new ArrayList<Pattern>();
		reader=new BufferedReader(new InputStreamReader(new FileInputStream(fileName)));
		String line=reader.readLine();
		while(line!=null)
		{
			if(line.trim().length()==0)
			{
				isTest=true;
				line=reader.readLine();
				continue;
			}
			if(isTest)
			{
				testList.add(line);
			}
			else
			{
				for(int i=0;i<line.length();i++)
				{
					
				}
				patternList.add(Pattern.compile(line));
			}
			line=reader.readLine();
		}
	}

	@After
	public void tearDown() throws Exception {
	}
	@Test
	public void testPattern()
	{
		
		for(int i=0;i<testList.size();i++)
		{
			for(int j=0;j<patternList.size();j++)
			{
				Pattern pattern=patternList.get(j);
			    Matcher matcher=pattern.matcher(testList.get(i));
			    if(matcher.matches())
			    {
			    	System.out.println("find:"+pattern.toString()+":"+testList.get(i));
			    	break;
			    }
			}
		}
		
	}

}
