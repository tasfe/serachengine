import java.util.*;
import java.io.*;
public class OutputManager {
	protected static OutputManager manager;
	protected static HashMap<String,OutputManager> map;
	protected String file;
	protected BufferedWriter writer;
	public static OutputManager get(String file)
	{
		if(map==null)
		{
			map=new HashMap<String,OutputManager>();
		}
		if(!map.containsKey(file))
		{
			map.put(file, new OutputManager(file));
		}
		return map.get(file);
	}
	public static OutputManager get()
	{
		return get("/home/jian/output.html");
	}
	protected OutputManager(String file)
	{
		this.file=file;
		
	}
	public synchronized void wirte(InputStream in)
	{
		if(this.writer==null)
		{
			try
			{
			this.writer=new BufferedWriter(new OutputStreamWriter(new FileOutputStream(file)));
			}
			catch(Exception e)
			{
				System.err.print("创建文件错误");
			}
		}
		try
		{
			BufferedReader reader=new BufferedReader(new InputStreamReader(in));
			String line=reader.readLine();
			while(line!=null)
			{
			this.writer.write(line+"\r\n");
			line=reader.readLine();
			}
			reader.close();
		}
		catch(IOException e)
		{
			System.err.println("写入数据错误");
		}
		
	}
	public synchronized void wirte(String content)
	{
		if(this.writer==null)
		{
			try
			{
			this.writer=new BufferedWriter(new OutputStreamWriter(new FileOutputStream(file)));
			}
			catch(Exception e)
			{
				System.err.print("创建文件错误");
			}
		}
		try
		{
			this.writer.write(content);
		}
		catch(IOException e)
		{
			System.err.println("写入数据错误");
		}
	}
	public void close()
	{
		try {
			this.writer.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
