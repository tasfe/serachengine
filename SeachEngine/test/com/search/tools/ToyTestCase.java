package com.search.tools;
import java.io.File;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import com.google.template.soy.SoyFileSet;
import com.google.template.soy.data.SoyMapData;
import com.google.template.soy.tofu.SoyTofu;

public class ToyTestCase {

	@Before
	public void setUp() throws Exception {
	}

	@After
	public void tearDown() throws Exception {
	}
	@Test
	public void testToy()
	{
		  // Bundle the Soy files for your project into a SoyFileSet.
	    SoyFileSet sfs = (new SoyFileSet.Builder()).add(new File("C:\\Documents and Settings\\Administrator\\×ÀÃæ\\one.soy")).build();

	    // Compile the template into a SoyTofu object.
	    // SoyTofu has a render method that can render all the templates in the SoyFileSet.
	    SoyTofu tofu = sfs.compileToJavaObj();

	    // Call the template with no data.
	    System.out.println(tofu.render("examples.simple.helloWorld", (SoyMapData) null, null));
	}

}
