package com.search.download;

public class Debug {
	public static boolean isDebug=false;
	public static void print(String value)
	{
		if(isDebug)
		{
		System.out.println(value);
		}
	}

}
