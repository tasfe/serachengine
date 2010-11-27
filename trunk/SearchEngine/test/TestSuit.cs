using System;
using System.Collections.Generic;
using System.Reflection;
namespace SearchEngine
{
	public class TestSuit
	{
		private List<Type> testList;
		public TestSuit ()
		{
			testList=new List<Type>();
			this.init();
		}
		public void start()
		{
			for(int i=0;i<testList.Count;i++)
			{
				Type type=testList[i];
				List<MethodInfo> methodList=new List<MethodInfo>();
				foreach(MethodInfo method in type.GetMethods(BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public))
				{
					if(method.GetCustomAttributes(new Test().GetType(),false).Length>0)
					{
						methodList.Add(method);
					}
				}
				object instance=Assembly.GetExecutingAssembly().CreateInstance(type.FullName);
				for(int j=0;j<methodList.Count;j++)
				{
					MethodInfo method=methodList[j];
					try
					{
					method.Invoke(instance,new object[]{});
					}
					catch(Exception ex)
					{
						//Exception happend
						
					}
				}
			}
		}
		private void init()
		{
			foreach(Type type in Assembly.GetExecutingAssembly().GetTypes())
			{
				if(type.IsSubclassOf(new TestCase().GetType()))
				{
					this.testList.Add(type);
				}
			}
		}
	}
}

