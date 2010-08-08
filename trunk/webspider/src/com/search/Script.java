package com.search;

import javax.script.ScriptEngine;
import javax.script.ScriptEngineManager;

public class Script {
	protected ScriptEngine engine;

	public Script() {
		this.engine = new ScriptEngineManager().getEngineByExtension("js");
	}

}
