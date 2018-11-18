using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottas_Flea_Market
{
	class Item
	{
		public string VendorName { get; }
		public int RegName { get; }
		public string Desc { get; }
		public Item(string vendorName, int regNumber, string desc)
		{
			VendorName = vendorName;
			RegName = regNumber;
			Desc = desc;
		}
	}
}
