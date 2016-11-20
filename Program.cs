using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieBakery
{
<<<<<<< HEAD

    /**
    * 
    * Has Customers Fred, Ted, and Greg
    * 
    * Implement flavors
    * 
    * If time, Make one spesific Glutenfree Cookie For "Need glutenfreeCookie Greg"
    * 
    * USE:
    * Factory
    * Designpattern
    * Singelton
    * 
    * Fred, Ted and Greg makes calls to this thread through their own threads.
    * Example every 100 millisec. (Number sligthy higher than backin time)
    * This Method needs this name because it says so in out asignment
    * 
    * Text-line outcome shold be "coustomer-thread, bakery-thread, flavore-thread"
    * 
    * */
    class Program
    {
        static Queue<int> cookies = new Queue<int>();
        const int CookieThreads = 3;
        static int[] sums = new int[CookieThreads];

        // The Lock placed here so we only get one at a time

        static void ProduceCookies()
        {
            for (int i = 1; i < 24; i++)
            {
                int cookieToEnqueue = i;
                Console.WriteLine("Bakery made cookie #" + cookieToEnqueue);
                lock (cookies)
                    cookies.Enqueue(cookieToEnqueue);
                Thread.Sleep(500);
            }

        }

        // This is the original lock


      //  static void Customers()



/**
 * This is the Custumer set-up 
 * 
 * Functions as:
 * Lock cookie from the (the first implemented lock in the code)
 * 
 * */


        static void Customer(Object threadCookie)   
        {
            DateTime startTime = DateTime.Now;
            int mySum = 0;
            while ((DateTime.Now - startTime).Seconds < 11)
            {
                int cookieToSum = -1;
                lock (cookies)
                {
                    if (cookies.Count != 0)
                    {
                        cookieToSum = cookies.Dequeue();
                    }
                }
                if (cookieToSum != -1)
                {
                    mySum += cookieToSum;
                    Console.WriteLine(" received Bakerys Cookie #" + cookieToSum); //name='{0}'
                }
            }
        }


    /**
    * Here is the last part of the Code
    * 
    * This is where the Cookie and Customer 
    * Methods/Classes are run(startet) from
    * 
    * */

    static void Main()
        {
            var producingThread = new Thread(ProduceCookies);
            producingThread.Start();
            Thread[] threads = new Thread[CookieThreads];
            for (int i = 0; i < CookieThreads; i++)
            {
                threads[i] = new Thread(Customer);
                threads[i].Start(i);
            }

            Console.WriteLine();
            Console.ReadKey( );
        }

    }
}

/*
        static void ArrayCustomers(Array arr)
        {
            Thread newThread = new Thread(Customer.GetName);
            newThread.Start(25);

            var n = new Customer();
            var cust = new Customer();
            newThread = new Thread(n.GetCustemoreName);
            newThread.Start("The answer.");
            
            var threadfred = new Thread(cust.coustumerfred);
            var threadted = new Thread(cust.coustumerted);
            var threadgreg = new Thread(cust.coustumergreg);
        }
        public static GetName(object name)
        {
            Console.WindowLeft(30);
        }
    * */
=======
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
>>>>>>> origin/master
