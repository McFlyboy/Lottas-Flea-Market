using Lottas_Flea_Market.solution.users;
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

		//Initialization of singleton
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
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write(" puts his/her item ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("#" + item.RegName);
				Console.ForegroundColor = ConsoleColor.Gray;
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

		//Returns true if the User was able to buy the desired Item
		public bool BuyItem(Customer customer, Item desiredItem)
		{
			lock (lockInteractWithInventory)
			{
				for (int i = 0; i < inventory.Count; i++)
				{
					if (desiredItem == inventory[i])
					{
						inventory.RemoveAt(i);
						string outputText = customer.Name + " bought " + desiredItem.VendorName + "'s item #" + desiredItem.RegName + " with " + desiredItem.Desc;
						Console.CursorLeft = Console.BufferWidth - outputText.Length;
						Console.ForegroundColor = ConsoleColor.Magenta;
						Console.Write(customer.Name);
						Console.ForegroundColor = ConsoleColor.Gray;
						Console.Write(" bought ");
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.Write(desiredItem.VendorName);
						Console.ForegroundColor = ConsoleColor.Gray;
						Console.Write("'s item ");
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("#" + desiredItem.RegName);
						Console.ForegroundColor = ConsoleColor.Gray;
						Console.Write(" with " + desiredItem.Desc);
						return true;
					}
				}
				return false;
			}
		}
	}
}
