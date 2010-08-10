package com.search;
import java.util.*;
import java.io.*;
import java.net.*;
public class Main {
	public static void main(String[] arg)
	{
		try
		{
			URL url=new URL("http://ptaobao.appspot.com");
			URLConnection urlCon=url.openConnection();
			System.out.println(urlCon.getContentType());
			for(String key :urlCon.getHeaderFields().keySet())
			{
				System.out.println(key+":"+urlCon.getHeaderField(key));
			}
			System.out.println(urlCon.getContentEncoding());
		    BufferedReader reader=new BufferedReader(new InputStreamReader(url.openStream()));
		    String line=reader.readLine();
		    System.in.read();
		    while(line!=null)
		    {
		    	System.out.println(line);
		    	line=reader.readLine();
		    }
		}
		catch(Exception e)
		{
			e.printStackTrace();
		}
		System.out.println("hello world");
	}

}
