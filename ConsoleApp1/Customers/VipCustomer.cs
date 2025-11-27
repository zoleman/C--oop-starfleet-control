using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Rides;

namespace ConsoleApp1.Customers
{
    public class VipCustomer : Customer
    {
        protected override int ToPay => 600;
        public VipCustomer(string name) : base (name) 
        {
            
        }

        public override void Ride(Ride ride)
        {
            rides.Add(ride);
        }
    }
}
