using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Rides;

namespace ConsoleApp1.Customers
{
    public abstract class Customer
    {
        public string Name { get; }
        public List<Ride> rides = new();
        protected abstract int ToPay { get; }

        public Customer(string name)
        { 
            Name = name;
        }

        public virtual void Ride(Ride ride)
        {
        
        }
    }
}
