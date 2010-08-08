package com.search;

/**
 * 系统配置文件设置
 * 
 * @author jian
 * 
 */
public class Config {
	/**
	 * 是否处于调试状态
	 */
	protected static boolean debug;
	/**
	 * 日志文件存放的位置
	 */
	protected static String logFolder;
	/**
	 * 下载的文件存储位置
	 */
	protected static String downFolder;
	/**
	 * 下载的数据库存储位置
	 */
	protected static String downDb;
	/**
	 * 是否允许线程
	 */
	protected static boolean enableThread;
	/**
	 *系统允许的最大线程的数目
	 */
	protected static int maxThread;
	/**
	 * 系统最大的内存使用量
	 */
	protected static long maxMem;
	/**
	 * 系统的分布点数目
	 */
	protected static int pointNum;
	/**
	 * 是否允许使用gui环境
	 */
	protected static boolean enableGui;
	static {
		// this is init the config
	}

	/**
	 * 保存当前设置
	 */
	public static void save() {

	}

	/**
	 * 恢复以前的设置如果有的话
	 */
	public static void restore() {

	}

	public static String getDownFolder() {
		return downFolder;
	}

	public static void setDownFolder(String downFolder) {
		Config.downFolder = downFolder;
	}

	public static String getDownDb() {
		return downDb;
	}

	public static void setDownDb(String downDb) {
		Config.downDb = downDb;
	}

	public static boolean isEnableThread() {
		return enableThread;
	}

	public static void setEnableThread(boolean enableThread) {
		Config.enableThread = enableThread;
	}

	public static int getMaxThread() {
		return maxThread;
	}

	public static void setMaxThread(int maxThread) {
		Config.maxThread = maxThread;
	}

	public static long getMaxMem() {
		return maxMem;
	}

	public static void setMaxMem(long maxMem) {
		Config.maxMem = maxMem;
	}

	public static int getPointNum() {
		return pointNum;
	}

	public static void setPointNum(int pointNum) {
		Config.pointNum = pointNum;
	}

	public static boolean isEnableGui() {
		return enableGui;
	}

	public static void setEnableGui(boolean enableGui) {
		Config.enableGui = enableGui;
	}

}
