package com.search.download;

import java.util.*;
import java.net.*;
import java.io.*;

/**
 * 下载线程
 * 
 * @author jian
 * 
 */
public class DownloadThread implements Runnable {
	protected ArrayList<String> urls;
	protected long beginTime;
	protected long endTime;
	protected long currentTime;
	protected boolean stopCmd = false;

	@Override
	public void run() {
		// TODO Auto-generated method stub
		beginTime = System.currentTimeMillis();
		while (!stopCmd) {

		}
		endTime = System.currentTimeMillis();
		System.out.println("waste time");

	}

	public void getCurrentRate() {

	}

	public void getTotalRate() {

	}

}
