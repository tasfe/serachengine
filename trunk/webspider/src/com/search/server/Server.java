package com.search.server;

import java.util.*;
import java.net.*;
import java.io.*;

public class Server implements Runnable {
	protected String serverName;
	protected int serverPort = 8080;
	protected ServerSocket server;
	protected Socket client;
	protected ThreadGroup clientHandler;
	protected ArrayList<Socket> clientList;

	protected void init() {
		try {
			this.server = new ServerSocket(this.serverPort);
			this.clientHandler = new ThreadGroup("client handler");
			this.clientList = new ArrayList<Socket>();

		} catch (IOException e) {
			System.out.println("创建服务器失败");
		}

	}

	public void Server() {
		this.init();
	}

	public void run() {
		while (true) {
			try {
				this.client = this.server.accept();
				this.clientList.add(this.client);
			} catch (IOException e) {

			}
		}
	}

}
