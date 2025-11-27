using ConsoleApp1.Customers;
using ConsoleApp1.Rides;
using static ConsoleApp1.Rides.Ride;

namespace ConsoleApp1
{
    public class Park
    {
        public List<Ride> rides = new List<Ride>();
        public List<Customer> customers = new List<Customer>();
        public RideType mostVIPCustomersInQueue;

        public Park() { }


        public void CalculateVIPCustomers()
        {

            
            foreach (var ride in rides)
            { 
                
            }
        }
    }
}
