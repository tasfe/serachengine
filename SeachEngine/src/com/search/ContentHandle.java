package com.search;
import java.util.*;
import java.util.regex.*;
/**
 * ���ݴ���ӿ�
 * @author my123jian@gmail.com
 *
 */
public abstract class ContentHandle {
	protected HashMap<Pattern,ContentHandle> handleMap;
	protected abstract void init();
    public ContentHandle()
    {
    	
    }
	

}
