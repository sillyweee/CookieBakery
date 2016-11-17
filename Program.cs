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


            Threadfred.Start();
            Threadted.Start();
            Threadgreg.Start();

            Console.ReadLine();

        }


        /**
        SellCookieTo(Customer customer)
        {
            //text goes here
        }
    **/

    }
    
}


