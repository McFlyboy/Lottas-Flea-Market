using System;
using Lottas_Flea_Market.solution.users;

namespace Lottas_Flea_Market
{
	class Demo
	{
		static void Main(string[] args)
		{
			Customer c1 = new Customer("Test_customer");
			Vendor v1 = new Vendor("Test_vendor");
			c1.Thread.Join();
			v1.Thread.Join();
			Console.WriteLine("Store closed.");
			Console.WriteLine("Press any key to close this demo...");
			Console.ReadKey(true);
		}
	}
}
