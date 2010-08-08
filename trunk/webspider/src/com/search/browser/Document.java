package com.search.browser;

public interface Document {
	Document open();
	void close();
	void write(String content);
	void writeln(String content);

}
