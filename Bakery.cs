using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieBakery
{
	public class Bakery
	{
		private readonly object _syncLock = new object();

		private Queue<Cookie> cookieQueue;
		public string name { get; private set; }

		public Bakery(string bakeryName)
		{
			name = bakeryName;
			cookieQueue = new Queue<Cookie>();
		}
		
		public void SellCookiesTo(Customer customer)
		{
			lock (_syncLock)
			{
				var soldCookie = cookieQueue.Dequeue();
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
					cookieQueue.Enqueue(randomCookie);
				}
				Console.WriteLine("Bakery {0} made cookie #{1} with {2}", 
								name, randomCookie.bakingOrder, randomCookie.type);
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