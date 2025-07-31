using static starfleet_control_csharp_zoleman.Ships.CargoShip;

namespace starfleet_control_csharp_zoleman.DockingResults
{
    internal class CargoManifest : DockingResult
    {
        public int ShipRegistrationCode { get; }
        public CargoType CargoType { get; }
        public int CargoAmount { get; }

        public CargoManifest(int registry, CargoType cargo, int cargoAmount)
        { 
            ShipRegistrationCode = registry;
            CargoType = cargo;
            CargoAmount = cargoAmount;
        }
    }
}
