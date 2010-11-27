
using System;

namespace SearchEngine
{


	public interface History
	{
		/// <summary>
		/// 判断一个网址是否访问
		/// </summary>
		/// <param name="url">
		/// A <see cref="System.String"/>
		/// </param>
		/// <returns>
		/// A <see cref="Boolean"/>
		/// </returns>
		Boolean isVisited(string url);
		/// <summary>
		/// 添加一个网址
		/// </summary>
		/// <param name="url">
		/// A <see cref="System.String"/>
		/// </param>
		void addNew(string url);
	}
}
