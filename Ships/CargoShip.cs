using starfleet_control_csharp_zoleman.DockingResults;
using starfleet_control_csharp_zoleman.Utils;

namespace starfleet_control_csharp_zoleman.Ships
{
    public class CargoShip : MobileSpacecraft
    {
        private static readonly int CargoBaseSpeed = 150;
        public enum CargoType
        {
            Food,
            Medicine,
            Weapons
        }
        public CargoType[] CargoBay { get; private set; }
        public int CargoAmount { get; private set; }


        public CargoShip(int registrationCode, string name, int commissionYear)
            : base(registrationCode, name, commissionYear, CargoBaseSpeed)
        {

            CargoBay = new CargoType[1];
            PickUpNewCargo();
        }

        public override void Dock(SpaceStation station)
        {
            var manifest = new CargoManifest(this.RegistrationCode, CargoBay[0], CargoAmount);
            Console.WriteLine($"Registration code: {this.RegistrationCode}. Dropping off {CargoBay[0]}, amount: {CargoAmount}.");
            PickUpNewCargo();
        }

        public void PickUpNewCargo()
        {
            CargoBay[0] = (CargoType)Util.random.Next(Enum.GetValues(typeof(CargoType)).Length);
            CargoAmount = Util.random.Next(6);
        }
    }
}
