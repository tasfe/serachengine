package com.search.tools;


import java.io.FileOutputStream;

import junit.framework.TestCase;

import org.apache.poi.hslf.model.Sheet;
import org.apache.poi.hssf.usermodel.HSSFSheet;
import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.ss.usermodel.Cell;
import org.apache.poi.ss.usermodel.CreationHelper;
import org.apache.poi.ss.usermodel.Row;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class ExcelTestCase extends TestCase{

	@Before
	public void setUp() throws Exception {
		HSSFWorkbook wb = new HSSFWorkbook();
	    FileOutputStream fileOut = new FileOutputStream("c:\\workbook.xls");
	    CreationHelper createHelper = wb.getCreationHelper();
	    HSSFSheet sheet = wb.createSheet("new sheet");

	    // Create a row and put some cells in it. Rows are 0 based.
	   for(int i=0;i<100;i++)
	   {
	    Row row = sheet.createRow((short)i);
	    // Create a cell and put a value in it.
	    Cell cell = row.createCell(0);
	    cell.setCellValue(1);

	    // Or do it on one line.
	    row.createCell(1).setCellValue(1.2);
	    row.createCell(2).setCellValue(
	         createHelper.createRichTextString("This is a string"));
	    row.createCell(3).setCellValue(true);
	   }

	    // Write the output to a file
	   
	    wb.write(fileOut);
	    fileOut.close();

	    wb.write(fileOut);
	    fileOut.close();

	}

	@After
	public void tearDown() throws Exception {
	}
	@Test
	public void testExcel()
	{
		
	}

}
