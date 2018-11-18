using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottas_Flea_Market
{
	class Store
	{
		private static Store instance = null;
		private readonly List<Item> inventory;
		private static object lockCreateInstance = new object();
		private object lockInteractWithInventory = new object();
		//Singleton
		private Store()
		{
			inventory = new List<Item>();
		}
		public static Store Instance
		{
			get
			{
				if (instance == null)
				{
					lock (lockCreateInstance)
					{
						if (instance == null)
						{
							instance = new Store();
							Console.WriteLine("Store opened.");
						}
					}
				}
				return instance;
			}
		}
		public void PutItemForSale(Item item)
		{
			lock (lockInteractWithInventory)
			{
				inventory.Add(item);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write(item.VendorName);
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write(" puts his/her item #");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(item.RegName);
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine(" up for sale.");
			}
		}
		public Item[] BrowseInventory()
		{
			lock (lockInteractWithInventory)
			{
				return inventory.ToArray();
			}
		}
		//Not done with this method yet!
		public bool BuyItem(Item desiredItem)
		{
			lock (lockInteractWithInventory)
			{
				return false;
			}
		}
	}
}
