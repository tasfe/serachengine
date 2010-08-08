package com.search;

import java.util.*;
import java.net.*;

public class DNSclient {
	protected HashMap<String, String> ipTable;
	protected static DNSclient instance;
	protected static InetAddress address;

	protected DNSclient() {
		this.ipTable = new HashMap<String, String>();
	}

	public static DNSclient get() {
		if (instance == null) {
			instance = new DNSclient();
		}
		return instance;
	}

	public String get(String key) {
		if (ipTable.containsKey(key)) {
			return ipTable.get(key);
		} else {
			if (address == null) {
				try {
					address = InetAddress.getByName(key);
					ipTable.put(key, address.getHostAddress());
				} catch (Exception e) {
					System.out.println(e);
				}
			}
		}
		return ipTable.get(key);
	}

}
