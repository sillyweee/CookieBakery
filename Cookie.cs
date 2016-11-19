using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieBakery
{
    class Cookie
    {
        int cookieContents;
        bool readerFlag = false;

        public int ReadFromCookie()
        {
            lock(this)
            {
                if(!readerFlag)
                {
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch(SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch(ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                Console.WriteLine("cookie: {0}", cookieContents);
                readerFlag = false;
                //Cookie.Pulse(this);
            }
            return cookieContents;
        }

        public void WriteToCookie(int c)
        {
            lock(this)
            {
                if (readerFlag)
                {
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch(SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch(ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                cookieContents = c;
                Console.WriteLine("Bakery: {0}", cookieContents);
                readerFlag = true;
                //Cookie.Pulse(this);
            }
        }
    }
}
