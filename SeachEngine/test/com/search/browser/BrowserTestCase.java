package com.search.browser;


import junit.framework.TestCase;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
/**
 * 测试模拟浏览器的功能是否正确
 * @author my123jian@gmail.com
 *
 */
public class BrowserTestCase extends TestCase {
	private Browser web;
	@Before
	public void setUp() throws Exception {
		web=new Browser();
	}

	@After
	public void tearDown() throws Exception {
	}
	@Test
	public void testBrowser()
	{
	assertEquals(1, 1);
	assertNull(web.getName());
	}

}
