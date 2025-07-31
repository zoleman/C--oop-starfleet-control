using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starfleet_control_csharp_zoleman.Utils
{
    public static class Util
    {
        public static Random random = new Random();
        private static List<int> registryNumbers = new List<int>();
        private static List<string> shipNames = new List<string>();
        private static string namesRelativePath = @"utils\names.txt";
        private static string[] lines = File.ReadAllLines(namesRelativePath);

        public static int GenerateRegistry()
        { 
            int ID = Util.random.Next(Int32.MaxValue);

            while (registryNumbers.Contains(ID))
            {
                ID = Util.random.Next(Int32.MaxValue);
            }

            registryNumbers.Add(ID);

            return ID;
        }

        public static string GenerateRegistryName()
        {
            string shipName = lines[random.Next(lines.Length)];
            
            while (shipNames.Contains(shipName))
            {
                shipName = lines[random.Next(lines.Length)];
            }

            shipNames.Add(shipName);

            return shipName;
            
            
        }


    }
}
