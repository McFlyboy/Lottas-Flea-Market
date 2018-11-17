using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lottas_Flea_Market.solution.users
{
	class Customer : User
	{
		public Customer() : base()
		{
			
		}
		//Thread execution starts here
		public override void Act()
		{
			while (true)
			{
				Thread.Sleep(500);
			}
		}
	}
}
