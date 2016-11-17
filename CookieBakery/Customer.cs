using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieBakery
{
    /**
     * Here we will put the Fred, Ted and Greg threads
     * 
     * Fred, Ted and Greg makes calls to this thread through their own threads.
     * Example every 100 millisec. (Number sligthy higher than backin time)
     * This Method needs this name because it says so in out asignment
     * 
     * */

    public class Customer
    {

        public int i = 0;

        public void customerfred()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Jeg er Fred");
                Thread.Sleep(2);
            }
        }

        public void customerted()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Jeg er Ted");
                Thread.Sleep(2);
            }
        }

        public void customergreg()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Jeg er Greg");
                Thread.Sleep(2);
            }
        }
    }
}