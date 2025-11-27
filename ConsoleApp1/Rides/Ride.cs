using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Customers;

namespace ConsoleApp1.Rides
{
    public abstract class Ride
    {
        public string Name { get; }
        public int Price { get; }
        public enum RideType
        {
            rotating,
            aquatic,
            train,
            driveable

        }
        public RideType Type { get; }
        public int MaxCustomers { get; }
        public List<Customer> customersOnRide = new();
        public Queue<Customer> customerQueue = new();

        public Ride(string name, int price, RideType rideType, int maxCustomers)
        { 
            Name = name;
            Price = price;
            Type = rideType;
            MaxCustomers = maxCustomers;
        }








    }
}
