package com.search;

/**
 * 搜索引擎主类
 * 
 * @author jian
 * 
 */
public class Engine {
	protected long maxMem;
	protected int maxThread;
	protected String fileFolder;
	protected String dbFolder;
	protected String logFolder;
	private Runtime runtime;

	public Engine() {
		this.runtime = Runtime.getRuntime();
		// System.setSecurityManager(null);
	}

	public void start() {

	}

	public void pause() {

	}

	public void stop() {

	}

	public void addMemWatcher() {

	}

	public void addThreadWatcher() {

	}

	public long getMaxMem() {
		return maxMem;
	}

	public void setMaxMem(long maxMem) {
		this.maxMem = maxMem;
	}

	public int getMaxThread() {
		return maxThread;
	}

	public void setMaxThread(int maxThread) {
		this.maxThread = maxThread;
	}

	public String getFileFolder() {
		return fileFolder;
	}

	public void setFileFolder(String fileFolder) {
		this.fileFolder = fileFolder;
	}

	public String getDbFolder() {
		return dbFolder;
	}

	public void setDbFolder(String dbFolder) {
		this.dbFolder = dbFolder;
	}

	public String getLogFolder() {
		return logFolder;
	}

	public void setLogFolder(String logFolder) {
		this.logFolder = logFolder;
	}

}
