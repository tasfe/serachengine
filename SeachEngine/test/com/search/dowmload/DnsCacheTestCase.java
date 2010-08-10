package com.search.dowmload;


import junit.framework.TestCase;
import java.io.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import com.search.download.Debug;
import com.search.download.DnsCache;

public class DnsCacheTestCase extends TestCase{

	String[]host=new String[10];
	boolean enableDebug;
	
	@Before
	public void setUp() throws Exception {
		enableDebug=Debug.isDebug;
		Debug.isDebug=true;
	
	}

	@After
	public void tearDown() throws Exception {
		Debug.isDebug=enableDebug;
	}
	@Test
	public void testCache()
	{
		assertNotNull(DnsCache.getIpAddress("baidu.com"));
		System.out.println(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("baidu.com"));assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("51.com"));
		assertNotNull(DnsCache.getIpAddress("tudou.com"));assertNotNull(DnsCache.getIpAddress("baidu.com"));
		assertNotNull(DnsCache.getIpAddress("youdao.com"));
		assertNotNull(DnsCache.getIpAddress("yahoo.com"));
		assertNotNull(DnsCache.getIpAddress("google.com"));
	}

}
