using starfleet_control_csharp_zoleman.Ships;
using starfleet_control_csharp_zoleman.Utils;

namespace starfleet_control_csharp_zoleman
{
    public class ControlCenter
    {
        public List<Spacecraft> spaceCrafts = new();
        private int _stations;
        private int _cargo;
        private int _disco;
        
        public ControlCenter(int stations, int cargo, int disco) 
        {
            _stations = stations;
            _cargo = cargo;
            _disco = disco;
        }

        public void GenerateFleet()
        {
            for (int i = 0; i < _stations; i++)
            {
                spaceCrafts.Add(new SpaceStation(Util.GenerateRegistry(), Util.GenerateRegistryName(), Util.random.Next(2100, 2251)));
            }

            for (int i = 0; i < _cargo; i++)
            {
                spaceCrafts.Add(new CargoShip(Util.GenerateRegistry(), Util.GenerateRegistryName(), Util.random.Next(2100, 2251)));
            }

            for (int i = 0; i < _disco; i++)
            {
                spaceCrafts.Add(new DiscoveryShip(Util.GenerateRegistry(), Util.GenerateRegistryName(), Util.random.Next(2100, 2251)));
            }
        }
    }
}
