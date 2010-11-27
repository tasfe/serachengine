using System;
using System.Threading;
namespace SearchEngine
{
	/// <summary>
	/// 
	/// </summary>
	public class TaskCase
	{
		protected long id;
		protected string name;
		public TaskCase ()
		{
		}
		public virtual void run()
		{
			
		}
		public virtual void start()
		{
			
		}
		public virtual void stop()
		{
			
		}
		public virtual bool isOver()
		{
			return true;
		}
	}
}

