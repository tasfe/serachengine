package com.search.tools;


import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics2D;
import java.awt.Rectangle;
import java.io.FileOutputStream;

import junit.framework.TestCase;

import org.apache.poi.hslf.model.PPGraphics2D;
import org.apache.poi.hslf.model.ShapeGroup;
import org.apache.poi.hslf.model.Slide;
import org.apache.poi.hslf.usermodel.SlideShow;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
/**
 * ª√µ∆∆¨µƒ≤‚ ‘ µœ÷
 * @author Administrator
 *
 */
public class PPTTestCase extends TestCase {

	@Before
	public void setUp() throws Exception {
		 SlideShow ppt = new SlideShow();
	        Slide slide = ppt.createSlide();

	        //draw a simple bar graph
	        //bar chart data. The first value is the bar color, the second is the width
	        Object[] def = new Object[]{
	            Color.yellow, new Integer(100),
	            Color.green, new Integer(150),
	            Color.gray, new Integer(75),
	            Color.red, new Integer(200),
	        };

	        //all objects are drawn into a shape group so we need to create one

	        ShapeGroup group = new ShapeGroup();
	        //define position of the drawing in the slide
	        Rectangle bounds = new java.awt.Rectangle(200, 100, 350, 300);
	        //if you want to draw in the entire slide area then define the anchor as follows:
	        //Dimension pgsize = ppt.getPageSize();
	        //java.awt.Rectangle bounds = new java.awt.Rectangle(0, 0, pgsize.width, pgsize.height);

	        group.setAnchor(bounds);
	        slide.addShape(group);

	        //draw a simple bar chart
	        Graphics2D graphics = new PPGraphics2D(group);
	        int x = bounds.x + 50, y = bounds.y + 50;
	        graphics.setFont(new Font("Arial", Font.BOLD, 10));
	        for (int i = 0, idx = 1; i < def.length; i+=2, idx++) {
	            graphics.setColor(Color.black);
	            int width = ((Integer)def[i+1]).intValue();
	            graphics.drawString("Q" + idx, x-20, y+20);
	            graphics.drawString(width + "%", x + width + 10, y + 20);
	            graphics.setColor((Color)def[i]);
	            graphics.fill(new Rectangle(x, y, width, 30));
	            y += 40;
	        }
	        graphics.setColor(Color.black);
	        graphics.setFont(new Font("Arial", Font.BOLD, 14));
	        graphics.draw(bounds);
	        graphics.drawString("Performance", x + 70, y + 40);

	        FileOutputStream out = new FileOutputStream("c:\\hslf-graphics2d.ppt");
	        ppt.write(out);
	        out.close();

	}

	@After
	public void tearDown() throws Exception {
	}
	@Test
	public void testPPT()
	{
		
	}

}
