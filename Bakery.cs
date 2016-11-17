using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/**
 * 
 * Change name to from flavored cookies to "(Bakary's-name) cookie"
 * 
 * Add a random flawor to the mix:
 * Vanilla, Chocolate, Glutenfree ++if we want more 
 * 
 * Cookies need to get a number that shows when they where "baked"
 * 
 * OBS!! minimum 12 cookies must be made before day is over!
 * 
 * */

namespace CookieBakery
{
    public class Bakery
    {
        public int i = 0;

        public void vaillacookie()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Vanilla cookie");
                Thread.Sleep(15);
            }                
        }

        public void chocolatecookie()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Chocolate cookie");
                Thread.Sleep(15);
            }
        }

        public void glutenfreecookie()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Glutenfree cookie");
                Thread.Sleep(15);
            }
        }

    }
}