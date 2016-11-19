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

        static void Main(string[] args)
        {
            Customer cust = new Customer();
            Thread Threadcustomer = new Thread(new ThreadStart(cust.customercookie));
            Bakery bake = new Bakery();
            Thread Threadbakery = new Thread(new ThreadStart(bake.cookiebakery));



            Threadcustomer.Start();
            Threadbakery.Start();

            Console.ReadLine();


            //This is still buggy, need to press enter(key) before i can Exit on escape(key)
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }


        /**
        SellCookieTo(Customer customer)
        {
            //text goes here
        }

        Console.Write("Bakery".PadRight(20));
        Console.Write("Customer".PadLeft(20));
      
    **/

    }

}