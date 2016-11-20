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