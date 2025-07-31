namespace starfleet_control_csharp_zoleman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many stations?");
            int stations = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many cargo ships?");
            int cargo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many explorers?");
            int disco = Int32.Parse(Console.ReadLine());
            ControlCenter controlCenter = new ControlCenter(stations, cargo, disco);

            controlCenter.GenerateFleet();

            Console.WriteLine(controlCenter.spaceCrafts[3].Name);
        }
    }
}
