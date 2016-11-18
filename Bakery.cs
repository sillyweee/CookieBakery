using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/**
 * 
 * The cookies shows by #number, the order they are baked
 * 
 * The Bakery's name are logical and easy to find the code to, because 
 * the name of the bakery is baked into the code
 * 
 * 
 * Add a random flawor to the mix:
 * Vanilla, Chocolate, Glutenfree ++if we want more 
 * 
 * OBS!! minimum 12 cookies must be made before day is over!
 * 
 * */

namespace CookieBakery
{
    public class Bakery
    {
        public int i = 0;

        public void martasbakery()
        {
            for (i = 1; i < 15; i++)
            {
                Console.WriteLine("Marta's Bakery" + " cookie #" + i);
                Thread.Sleep(1000);
            }                
        }
    
        public void littlebakery()
        {
           for (i = 1; i < 15; i++)
          {
                Console.WriteLine("The Little Bakery" + " cookie #" + i);
                Thread.Sleep(1000);
            }
        }

        public void organicbakery()
        {
            for (i = 1; i < 15; i++)
            {
                Console.WriteLine("Organic Bakery" + " cookie #" + i);
                Thread.Sleep(1000);
            }
        }


    
    }
}