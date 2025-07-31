namespace starfleet_control_csharp_zoleman.Ships
{
    public class SpaceStation : ImmobileSpacecraft
    {
        public MobileSpacecraft[] spaceDock;
        public SpaceStation(int registrationCode, string name, int commissionYear) 
            : base(registrationCode, name, commissionYear)
        {
            spaceDock = new MobileSpacecraft[2];
        }
    }
}
