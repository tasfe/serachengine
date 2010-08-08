import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.InetSocketAddress;
import java.net.Proxy;
import java.net.URL;
import java.net.URLConnection;

/**
 * 测试入口和帮助入口
 * 
 * @author jian
 * 
 */
public class Main {
	protected static boolean enableUI;
	protected static long engineId;
	protected static BufferedReader reader;
	protected static final String Help = "help";
	protected static String href = "<a\\s*href=(\\\'|\\\")([^\\\'\\\"]*)\\1[^>]*>";

	/**
	 * 输出帮助文件的内容
	 */
	protected static void printHelp() {
		try {
			
			reader = new BufferedReader(new InputStreamReader(
					getResourceAsStream("help")));
			String line = reader.readLine();
			while (line != null) {
				if (!line.startsWith("#")) {
					System.out.println(line);
				}
				line = reader.readLine();
			}
		} catch (IOException e) {
			System.out.println("read help file error");
		} catch (Exception e) {
			System.out.println("system error happen");
		}
	}

	private static InputStream getResourceAsStream(String string) {
		// TODO Auto-generated method stub
		return null;
	}

	/**
	 * 应用的入口设计程序
	 * 
	 * @param args
	 */
	public static void main(String[] args) 
	{
	try
	{
	Proxy p=new Proxy(Proxy.Type.HTTP,new InetSocketAddress("24.25.26.82",80));
	URL url=new URL("http://www.baidu.com");
	URLConnection urlcon=url.openConnection(p);
	System.out.println(urlcon.getContentLength());
	}
	catch(Exception ex)
	{
		ex.printStackTrace();
	}
	}

}
