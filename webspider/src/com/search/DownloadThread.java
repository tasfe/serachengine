package com.search;

import java.util.*;
import java.net.*;
import java.io.*;

/**
 * 下载线程负责下载数据
 * 
 * @author jian
 * 
 */
public class DownloadThread implements Runnable {

	protected ArrayList<String> downloadList;
	protected ArrayList<DownloadCallback> callbackList;
	protected int position;
	protected boolean stopCmd = false;

	/**
	 * 得到当前的下载地址
	 */
	public synchronized String getCurrentUrl() {
		return downloadList.get(position);
		// return null;
	}

	public synchronized void addEventListener(DownloadCallback back) {
		this.callbackList.add(back);
	}

	public synchronized void removeEventListener() {

	}

	public synchronized void clearEventListener() {

	}

	/**
	 * 初始化一个线程
	 */
	public DownloadThread() {

	}

	/**
	 * 添加一个任务
	 * 
	 * @param url
	 */
	public synchronized void addUrl(String url) {
		this.downloadList.add(url);
	}

	/**
	 * 添加多个任务
	 * 
	 * @param url
	 */
	public synchronized void addUrls(ArrayList<String> url) {
		this.downloadList.addAll(url);
	}

	/**
	 * 访问网址加入历史
	 */
	private void addHistory() {
		ArrayList<String> visitList = new ArrayList<String>();
		for (int i = 0; i < this.position; i++) {
			visitList.add(this.downloadList.get(i));

		}
	}

	public synchronized void stop() {
		stopCmd = true;
	}

	@Override
	public void run() {
		BufferedReader reader;
		StringBuffer buffer = new StringBuffer();
		String contentType;
		String line;
		URL url;
		// TODO Auto-generated method stub
		while (!stopCmd) {
			if (this.position >= this.downloadList.size()) {
				break;
			}
			try {
				url = new URL(this.getCurrentUrl());
				contentType = url.openConnection().getContentType();
				buffer.setLength(0);
				reader = new BufferedReader(new InputStreamReader(url
						.openStream()));
				line = reader.readLine();
				while (line != null) {
					buffer.append(line + "\r\n");
				}
			} catch (Exception e) {
				System.out.println(e);
			}

		}

	}

}
