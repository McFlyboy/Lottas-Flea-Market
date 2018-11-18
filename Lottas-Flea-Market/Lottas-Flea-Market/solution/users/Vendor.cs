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
		//Some pre-made descriptions for demo-purposes
		private static readonly string[] descriptions =
		{
			"basic features",
			"basic features and a minor dent",
			"basic features and a minor dent and a missing piece",
			"basic features and some customization"
		};
		public Vendor(string name) : base(name) { }

		//Thread execution starts here
		public override void Act()
		{
			int itemsPutUpForSale = 0;

			//Put 15 items up for sale
			while (itemsPutUpForSale < 15)
			{
				Store.PutItemForSale(new Item(Name, ++itemsPutUpForSale, descriptions[Random.Next(descriptions.Length)]));

				//Take a break
				Thread.Sleep(1000);
			}
		}
	}
}
