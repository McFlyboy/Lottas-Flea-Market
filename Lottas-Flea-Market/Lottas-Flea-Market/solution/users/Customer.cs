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
			while (itemsBought < 10)
			{
				//Breaks out of loop after 20 seconds incase the Customer couldn't find at least 10 items to buy 
				if ((int)time.ElapsedMilliseconds >= 20_000)
				{
					break;
				}
				//Browsing the inventory and picking out a random item to buy
				Item[] inventory = Store.BrowseInventory();
				Item desiredItem;
				lock (LockGetRandom)
				{
					desiredItem = inventory[Random.Next(inventory.Length)];
				}
				if (Store.BuyItem(desiredItem))
				{
					itemsBought++;
				}
				Thread.Sleep(1000);
			}
		}
	}
}
