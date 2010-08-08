package com.search;

import java.util.*;

/**
 * 内存中的一个快速哈希表 判断一个网址是否已经访问
 * 
 * @author jian
 * 
 */
public class History {
	/**
	 * 使用hash表
	 */
	private HashSet<String> listSet;
	/**
	 * 使用排序树操作
	 */
	private TreeSet<String> treeSet;
	private static History history;

	protected History() {
		listSet = new HashSet<String>();
	}

	/**
	 * 判断当前的地址是否访问
	 * 
	 * @param url
	 * @return
	 */
	public synchronized static boolean isVisited(String url) {
		if (history == null) {
			history = new History();
		}
		if (history.listSet.contains(url)) {
			return true;
		} else {
			return false;
		}
	}

	/**
	 * 添加一个访问的地址
	 * 
	 * @param url
	 */
	public synchronized static void addUrl(String url) {
		if (history == null) {
			history = new History();
		}
		history.listSet.add(url);
		return;
	}

	public synchronized static void addUrl(ArrayList<String> url) {
		if (history == null) {
			history = new History();
		}
		for (String item : url) {
			history.listSet.add(item);
		}
		return;
	}

}
