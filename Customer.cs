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
        private string[,] customername;

        public string[,] Bakeryname
        {
            get
            {
                return customername;
            }

            set
            {
                customername = value;
            }
        }


        public void customercookie()
        {
            for (i = 1; i < 20; i++)
            {
                Console.WriteLine(customername + " received cookie #" + i);
                Thread.Sleep(300);
            }
        }
    }
}