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
					instance = new Store();
				}
				return instance;
			}
		}
	}
}
