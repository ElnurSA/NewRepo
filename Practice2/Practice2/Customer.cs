using System;
namespace Practice2
{
	public class Customer
	{
		static int instanceCount = 0;

		public Customer()
		{
			instanceCount++;

		}

		public static void GetInstance()
		{
			Console.WriteLine(instanceCount);
		}
	}
}

