package com.search.browser;

import javax.script.*;

/**
 * 脚本模拟控制运行器实现
 * 
 * @author jian
 * 
 */
public class ScriptManager {
	protected ScriptEngine engine;
	protected ScriptEngineManager engineManager;
	protected String extension = "js";

	public ScriptManager() {
		this.engineManager = new ScriptEngineManager();
		this.engine = this.engineManager.getEngineByExtension(this.extension);
	}

	public void init() {

	}

	/**
	 * 运行脚本文件
	 * 
	 * @param script
	 * @throws Exception
	 */
	public void eval(String script) throws Exception {
		if (script != null) {
			script = script.trim();
			if (script.length() > 0) {

			}
		}
	}

}
