package com.search;

import java.util.*;
import java.util.regex.*;

/**
 * 完整的格式书写
 * 
 * @author jian
 * 
 */
public class WebAddress {
	static Pattern url = Pattern.compile("(http|ftp)://.*");

	public static String getAddress(String base, String path) {
		if (path == null || path.trim().length() == 0) {
			return base;
		}
		String[] pathPart = path.split("/");
		for (int i = 0; i < pathPart.length; i++) {

		}
		if (path.startsWith("javascript:")) {

		}
		if (path.startsWith("/")) {
			return base + path;
		}
		if (path.startsWith("#")) {
			return base;
		}
		if (path.startsWith("../")) {

		}
		return null;
	}

	public static HashMap<String, String> getParm(String url) {
		HashMap<String, String> parm = new HashMap<String, String>();
		return null;
	}

	public static String getProtocol(String url) {
		return null;
	}

}
