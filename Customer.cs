﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieBakery
{
	public class Customer
    {
<<<<<<< HEAD
        private int i = 0;

        public void coustumerfred(Object customernavn)
        {
            for(i = 0; i < 0; i++){
                Console.WriteLine("Fred");
                Thread.Sleep(300);
                return;
            }
        }
        public void coustumergreg(Object customernavn)
        {
            for (i = 0; i < 0; i++)
            {
                Console.WriteLine("Greg");
                Thread.Sleep(300);
                return;
            }
        }

        public void coustumerted(Object customername)
        {
            for (i = 0; i < 0; i++)
            {
                Console.WriteLine("Ted");
                Thread.Sleep(300);
                return;
            }
        }


=======
		public string Name { get; private set; }
	    public Customer(string name)
	    {
		    Name = name;
	    }

	    public override string ToString()
	    {
		    return Name;
	    }
>>>>>>> origin/master

    }
}

