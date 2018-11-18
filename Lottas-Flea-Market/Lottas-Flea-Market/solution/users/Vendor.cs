using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lottas_Flea_Market.solution.users
{
	class Vendor : User
	{
		public Vendor(string name) : base(name) { }
		//Thread execution starts here
		public override void Act()
		{
			int itemsPutUpForSale = 0;
			while (itemsPutUpForSale < 10)
			{
				Store.PutItemForSale(new Item(Name, ++itemsPutUpForSale, "Description"));
				Thread.Sleep(1000);
			}
		}
	}
}
