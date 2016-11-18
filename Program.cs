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
     * Factory  - - Cookie - Customer - Factory (Bakery?)
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
            Bakery bake = new Bakery();

            // Start(1)!! : This is test code that will be removed
            Thread Threadfred = new Thread(new ThreadStart(cust.customerfred));
            Thread Threadted = new Thread(new ThreadStart(cust.customerted));
            Thread Threadgreg = new Thread(new ThreadStart(cust.customergreg));
            Thread Threadmarta = new Thread(new ThreadStart(bake.martasbakery));
            Thread Threadlittle = new Thread(new ThreadStart(bake.littlebakery));
            Thread Threadorganic = new Thread(new ThreadStart(bake.organicbakery));
            //End(1)!!

            Threadfred.Start();
            Threadted.Start();
            Threadgreg.Start();
            Threadmarta.Start();
            Threadlittle.Start();
            Threadorganic.Start();

            Console.ReadLine();

            //This is still buggy, need to press enter(key) before i can Exit on escape(key)
            /**
            var key = Console.ReadKey();
            if(key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            **/


        }


        /**
        SellCookieTo(Customer customer)
        {
            //text goes here
        }
    **/

    }

}