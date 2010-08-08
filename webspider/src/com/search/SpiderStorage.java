package com.search;

import java.sql.*;
import java.util.*;

/**
 * 数据库的存储接口设计 网址 参数列表 引用次数 具体内容 记录时间
 * 
 * @author jian
 * 
 */
public class SpiderStorage {
	protected Connection sqlCon;
	static {
		try {
			Class.forName("org.hsqldb.jdbc.JDBCDriver");
		} catch (Exception e) {
			System.err.println(e);
		}
	}

}
