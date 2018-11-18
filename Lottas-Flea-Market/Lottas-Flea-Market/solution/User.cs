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
		public static Random Random { get; } = new Random();
		protected static object LockGetRandom { get; set; } = new object();
		public string Name { get; }
		protected Store Store { get; }
		public Thread Thread { get; }
		public User(string name)
		{
			Name = name;
			Store = Store.Instance;
			Thread = new Thread(new ThreadStart(Act));
			Thread.Start();
		}
		//Method that decides the actions of the User
		public abstract void Act();
	}
}
