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
        static Random rand = new Random(50);
        const int CookieThreads = 3;
        static int[] sums = new int[CookieThreads];
        static void ProduceCookies()
        {
            for (int i = 1; i < 24; i++)
            {
                int cookieToEnqueue = rand.Next(10);
                Console.WriteLine("Bakery made cookie #" + cookieToEnqueue);
                lock (cookies)
                    cookies.Enqueue(cookieToEnqueue);
                Thread.Sleep(500);
            }

        }
        static void SumCookies(Object threadCookie)

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
                    Console.WriteLine(" recived Bakerys Cookie #" + cookieToSum);

                }
            }
            sums[(int)threadCookie] = mySum;
        }
        static void Main()
        {
            var producingThread = new Thread(ProduceCookies);
            producingThread.Start();
            Thread[] threads = new Thread[CookieThreads];
            for (int i = 0; i < CookieThreads; i++)
            {
                threads[i] = new Thread(SumCookies);
                threads[i].Start(i);
            }
            for (int i = 1; i < CookieThreads; i++)
                threads[i].Join();
            int totalSum = 0;
            for (int i = 1; i < CookieThreads; i++)
                totalSum += sums[i];
            Console.WriteLine("Bakery closed for the day" + totalSum);
            Console.ReadKey( );
        }

    }
}