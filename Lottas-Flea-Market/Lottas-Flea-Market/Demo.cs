using System;
using Lottas_Flea_Market.solution.users;

namespace Lottas_Flea_Market
{
	class Demo
	{
		static void Main(string[] args)
		{
			Vendor v1 = new Vendor("Lotta");
			Vendor v2 = new Vendor("Angelina");
			Customer c1 = new Customer("Roger");
			Customer c2 = new Customer("John");
			Customer c3 = new Customer("Thomas");

			//Wait for vendors and customers to finish their business
			v1.Thread.Join();
			v2.Thread.Join();
			c1.Thread.Join();
			c2.Thread.Join();
			c3.Thread.Join();

			//Close
			Console.WriteLine("Store closed.");
			Console.WriteLine("Press any key to close this demo...");
			Console.ReadKey(true);
		}
	}
}
