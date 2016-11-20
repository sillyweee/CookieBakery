using System;
using System.Collections.Generic;
using System.Threading;

namespace CookieBakery
{
	public class Bakery
	{
		private readonly object _syncLock = new object();

		public Queue<Cookie> CookieQueue { get; }
		public string Name { get; private set; }

		public Bakery(string bakeryName)
		{
			Name = bakeryName;
			CookieQueue = new Queue<Cookie>();
		}

		public void SellCookiesTo(Customer customer)
		{
			lock (_syncLock)
			{
				var soldCookie = CookieQueue.Dequeue();
				//Find a way to print this string with right justification
				Console.WriteLine("{0} bought cookie #{1} with {2}",
					customer, soldCookie.bakingOrder, soldCookie.type);
			}
			Thread.Sleep(850);
		}

		public void ProduceCookies()
		{
			Random rand = new Random();
			CookieType choice;
			Cookie randomCookie;


			for (int i = 1; i < 24; i++)
			{
				lock (_syncLock)
				{
					choice = (CookieType) rand.Next(0, 3);
					randomCookie = factory(choice);
					randomCookie.bakingOrder = i;
					CookieQueue.Enqueue(randomCookie);
				}
				Console.WriteLine("Bakery {0} made cookie #{1} with {2}",
					Name, randomCookie.bakingOrder, randomCookie.type);
				Thread.Sleep(500);
			}
		}

		private Cookie factory(CookieType type)
		{
			Cookie newCookie;
			switch (type)
			{
				case CookieType.Vanilla:
					newCookie = new Cookie("vanilla");
					break;
				case CookieType.Raisins:
					newCookie = new Cookie("raisins");
					break;
				case CookieType.Chocolate:
					newCookie = new Cookie("chocolate");
					break;
				default:
					newCookie = new Cookie("##No_cookie_type_given##");
					break;
			}
			return newCookie;
		}
	}
}