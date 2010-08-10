package com.search.download;
import java.util.HashMap;
import java.net.*;
public class DnsCache {
	/**
	 * ip地址记录的表格数据
	 */
	static HashMap<String,String> ipTable;
	/**
	 * 得到域名的ip地址
	 * @param host 主机名字
	 * @return 返回ip地址
	 */
	public static synchronized String getIpAddress(String host)
	{
		if(ipTable==null)
		{
			ipTable=new HashMap<String,String>();
		}
		
		{
			String value=ipTable.get(host);
			if(value!=null)
			{
				return value;
			}
			else
			{
				try
				{
				String address=InetAddress.getByName(host).toString();
				if(address!=null)
				{
				 ipTable.put(host, value);
				 return address;
				}
				} catch (UnknownHostException e) {
					// 未知的域名信息
					e.printStackTrace();
				
				}
				
			}
		}
	
		return null;
	}

}
