using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieBakery
{
    public class Bakery
    {
        public int i = 0;

        public void vaillacookie()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("omnomnom Vanilla cookie");
                Thread.Sleep(15);
            }                
        }

        public void chocolatecookie()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("omnomnom Chocolate cookie");
                Thread.Sleep(15);
            }
        }

        public void glutenfreecookie()
        {
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("omnomnom Glutenfree cookie");
                Thread.Sleep(15);
            }
        }

    }
}