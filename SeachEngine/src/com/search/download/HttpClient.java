package com.search.download;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.net.Socket;
import java.net.URI;
import java.util.HashMap;
/**
 * 
 * @author my123jian@gmail.com
 *
 */
public class HttpClient {
	public class Config
	{
	public String userAgent="";
	public String accept="";
	}
	protected HashMap<String,String> header;
	protected HashMap<String,String> parmper;
	protected HashMap<String,String> cookie;
	protected Socket client;
	protected BufferedReader reader;
	protected DataInputStream breader;
	protected URI uri;
	/**
	 * 设置http的都不信息
	 * @param key
	 * @param value
	 */
	public void setHeader(String key,String value)
	{
		
	}

}
