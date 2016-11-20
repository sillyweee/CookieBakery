using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieBakery
{
/**
		    * 
		    * Has Customers Fred, Ted, and Greg
		    * 
		    * Implement flavors
		    * 
		    * If time, Make one spesific Glutenfree Cookie For "Need glutenfreeCookie Greg"
		    * 
		    * USE:
		    * Factory DP
		    * 
		    * Fred, Ted and Greg makes calls to this thread through their own threads.
		    * Example every 100 millisec. (Number sligthy higher than backin time)
		    * This Method needs this name because it says so in out asignment
		    * 
		    * 
		    * */

	internal class Program
	{
		/*
		static Queue<int> cookies = new Queue<int>();
		const int CookieThreads = 3;
		static int[] sums = new int[CookieThreads];
		*/
		private static Bakery bakery;
		private static List<Customer> customers;
		private static Thread factoryThread;
		private static Thread customerThread;

		public static void Main()
		{
			
			bakery = new Bakery("Mamma's");

			customers = new List<Customer> {new Customer("Ted"), new Customer("Fred"), new Customer("Greg")};

			factoryThread = new Thread(new ThreadStart(bakery.ProduceCookies));
			customerThread = new Thread(new ThreadStart(customerBuys));

			factoryThread.Start();
			customerThread.Start();

			factoryThread.Join();
			customerThread.Join();


		}

		private static void customerBuys()
		{
			Random rand = new Random();
			while (factoryThread.IsAlive)
			{
				int index = rand.Next(customers.Count);
				bakery.SellCookiesTo(customers[index]);
			}
			
		}
	}
}