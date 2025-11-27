using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Rides;

namespace ConsoleApp1.Customers
{
    public class BudgetCustomer : Customer
    {
        protected override int ToPay => rides.Sum(ride => ride.Price);
        public BudgetCustomer(string name) : base(name) 
        { 
                    }

        public override void Ride(Ride ride)
        {
            rides.Add(ride);
        }
    }
}
