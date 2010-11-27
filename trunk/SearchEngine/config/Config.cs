
using System;
using System.IO;
namespace SearchEngine
{

	/// <summary>
	/// 系统配置文件
	/// </summary>
	public class Config
	{

		/// <summary>
		/// dns服务器地址默认为本机
		/// </summary>
		protected String dnsServer="localhost";
		/// <summary>
		/// 历史管理服务器地址默认为本机
		/// </summary>
		protected String historyServer="localhost";
		/// <summary>
		/// 下载的文件的位置
		/// </summary>
		protected String folder;
		/// <summary>
		/// 是否允许线程
		/// </summary>
		protected Boolean enableThread=true;
		/// <summary>
		/// 是否允许数据库
		/// </summary>
		protected Boolean enableDb=false;
		protected long runNum=1;
		protected static Config instance=null;
		protected Config ()
		{
			
		}
		/// <summary>
		/// 生成一个空白的配置文件
		/// </summary>
		/// <returns>
		/// A <see cref="Config"/>
		/// </returns>
		public static Config get()
		{
			if(instance==null);
			{
				instance=new Config();
			}
			return instance;
		}
		/// <summary>
		/// 从指定的文件加载配置
		/// </summary>
		/// <param name="file">
		/// A <see cref="String"/>
		/// </param>
		/// <returns>
		/// A <see cref="Config"/>
		/// </returns>
		public static Config load(String file)
		{
			if(instance==null);
			{
				instance=new Config();
			}
			return null;
		}
		/// <summary>
		/// 保存当前的配置
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/>
		/// </param>
		public void save(String path)
		{
			
		}
	}
}
