package com.search;

import java.io.StringReader;
import org.w3c.dom.Document;
import org.w3c.tidy.Tidy;

/**
 * 解析文档并处理
 * 
 * @author jian
 * 
 */
public class Dom {
	protected boolean debug = false;
	protected String baseUrl;
	protected Tidy tidy;
	protected String content;
	protected String encoding;

	/**
	 * 
	 * @param baseurl
	 *            文档地址
	 * @param content
	 *            文档内容
	 */
	public Dom() {
		tidy = new Tidy();
		tidy.setShowWarnings(false);

	}

	/**
	 * 设置文本的编码方式
	 * 
	 * @param encoding
	 */
	public void setCharEncoding(String encoding) {
		this.encoding = encoding;

	}

	/**
	 * 设置基本地址
	 * 
	 * @param url
	 */
	public void setBaseUrl(String url) {
		this.baseUrl = url;
	}

	public Document getDocument() {
		tidy.setXHTML(true);
		return tidy.parseDOM(new StringReader(this.content), null);
	}

	public void setContent(String content) {
		this.content = content;

	}

}
