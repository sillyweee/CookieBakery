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
     * */
    class Program
    {

        static void Main(string[] args)
        {
            Customer cust = new Customer();
            Thread Threadfred = new Thread(new ThreadStart(cust.customerfred));
            Thread Threadted = new Thread(new ThreadStart(cust.customerted));
            Thread Threadgreg = new Thread(new ThreadStart(cust.customergreg));

            Bakery bake = new Bakery();
            Thread Threadvanillacookie = new Thread(new ThreadStart(bake.vaillacookie));
            Thread Threadchocolatecookie = new Thread(new ThreadStart(bake.chocolatecookie));
            Thread Threadglutenfreecookie = new Thread(new ThreadStart(bake.glutenfreecookie));

            Threadfred.Start();
            Threadted.Start();
            Threadgreg.Start();
            Threadvanillacookie.Start();
            Threadchocolatecookie.Start();
            Threadglutenfreecookie.Start();

            Console.ReadLine();

            //This is still abit buggy, need to press enter before i can Exit on escape-button
            var key = Console.ReadKey();
            if(key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }


        /**
        SellCookieTo(Customer customer)
        {
            //text goes here
        }
    **/

    }

}