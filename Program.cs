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
        static Random rand = new Random(0);
        const int CookieThreads = 1;
        static int[] sums = new int[CookieThreads];

        // The Lock placed here so we only get one at a time

        static void ProduceCookies()
        {
            for (int i = 1; i < 20; i++)
            {
                int cookieToEnqueue = i;
                Console.WriteLine("Bakery made cookie #" + cookieToEnqueue);
                lock (cookies)
                    cookies.Enqueue(cookieToEnqueue);
                Thread.Sleep(500);
            }

        }

        // This is the original lock

        static void Customer(Object threadCookie)
            //= rand.Next(10)
        {
            
            DateTime startTime = DateTime.Now;
            int mySum = 0;
            while ((DateTime.Now - startTime).Seconds < 11)
            {
                int cookieToSum = 0;
                  lock (cookies)
                {
                    if (cookies.Count != 0)
                    {
                        cookieToSum = cookies.Dequeue();
                    }
                }
                if (cookieToSum != 0)
                {
                    mySum += cookieToSum;
                    Console.WriteLine(" recived Bakerys Cookie #" + cookieToSum);
                    Thread.Sleep(300);

                }
            }
        }



/**
* This is the last step, 
* 
* These starts up the application CookieBakery
* 
* 
* And closes it after 
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
            Console.ReadKey();
        }
    }
}
/**
        class MySychonizedQueue<T>
        {
            Queue<T> theQ = new Queue<T>();
            public void Enqueue(T item)
            {
                lock (theQ)
                    theQ.Enqueue(item);
            }
            public T Dequeue()
            {
                lock (theQ)
                    return theQ.Dequeue();
            }
            public int Count
            {
                get { lock (theQ) return theQ.Count; }
            }
        }

**/
