using starfleet_control_csharp_zoleman.DockingResults;

namespace starfleet_control_csharp_zoleman.Ships
{
    public class DiscoveryShip : MobileSpacecraft
    {
        private static readonly int CargoBaseSpeed = 450;
        private List<DockingResult> _log = new();
        public DiscoveryShip(int registrationCode, string name, int commissionYear) 
            : base(registrationCode, name, commissionYear, CargoBaseSpeed)
        {

        }

        public override void Dock(SpaceStation station)
        {
            _log.Add(new DiscoveryDockingResult(station.RegistrationCode));
        }
    }
}
