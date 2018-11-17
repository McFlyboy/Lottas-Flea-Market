using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lottas_Flea_Market
{
	abstract class User
	{
		protected Store Store { get; }
		public User()
		{
			Store = Store.Instance;
			Thread thread = new Thread(new ThreadStart(Act));
			thread.Start();
		}
		public abstract void Act();
	}
}
