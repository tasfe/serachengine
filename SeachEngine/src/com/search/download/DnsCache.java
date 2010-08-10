package com.search.download;
import java.util.HashMap;
import java.net.*;
public class DnsCache {
	/**
	 * ip��ַ��¼�ı������
	 */
	static HashMap<String,String> ipTable;
	/**
	 * �õ�������ip��ַ
	 * @param host ��������
	 * @return ����ip��ַ
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
					// δ֪��������Ϣ
					e.printStackTrace();
				
				}
				
			}
		}
	
		return null;
	}

}
