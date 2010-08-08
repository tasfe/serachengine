package com.search;

/**
 * 下载过程中出现的事件处理
 * 
 * @author jian
 * 
 */
public interface DownloadCallback {
	void onError();

	void onLoad();

}
