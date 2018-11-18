using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lottas_Flea_Market.solution.users
{
	class Customer : User
	{
		public Customer(string name) : base(name) { }

		//Thread execution starts here
		public override void Act()
		{
			int itemsBought = 0;
			Stopwatch time = new Stopwatch();
			time.Start();

			//Buy 10 items
			while (itemsBought < 10)
			{
				//Breaks out of loop after 35 seconds incase the Customer couldn't find at least 10 items to buy 
				if ((int)time.ElapsedMilliseconds >= 35_000)
				{
					break;
				}

				//Browsing the inventory and picking out a random Item to buy
				Item[] inventory = Store.BrowseInventory();
				Item desiredItem = null;
				lock (LockGetRandom)
				{
					//Cheak if there are items to buy in the Store
					if (inventory.Length > 0)
					{
						//Pick a random Item to buy
						desiredItem = inventory[Random.Next(inventory.Length)];
					}
				}
				if (desiredItem != null)
				{
					//Buy desired Item
					if (Store.BuyItem(this, desiredItem))
					{
						//Bought a new Item
						itemsBought++;
					}

				}
				//Take a break
				Thread.Sleep(1000);
			}
		}
	}
}
