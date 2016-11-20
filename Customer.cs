using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CookieBakery
{
	public class Customer
    {
		public string Name { get; private set; }
	    public Customer(string name)
	    {
		    Name = name;
	    }

	    public override string ToString()
	    {
		    return Name;
	    }

    }
}

