package com.search;

import java.util.*;

public class DownloadManager implements Runnable {
	protected ThreadGroup downloadGroup;
	protected DownloadThread downThread;

	public DownloadManager() {
		this.downloadGroup = new ThreadGroup("downloadGroup");
	}

	public synchronized void addUrl(String url) {
		// if(this.downloadGroup.)
	}

	public synchronized void addUrls(ArrayList<String> urls) {

	}

	@Override
	public void run() {
		// TODO Auto-generated method stub

	}

}
