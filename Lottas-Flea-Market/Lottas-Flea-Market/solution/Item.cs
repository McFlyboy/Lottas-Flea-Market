using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottas_Flea_Market
{
	class Item
	{
		public string SalerName { get; }
		public int RegName { get; }
		public string Desc { get; }
		public Item(string salerName, int regNumber, string desc)
		{
			SalerName = salerName;
			RegName = regNumber;
			Desc = desc;
		}
	}
}
