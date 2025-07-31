namespace starfleet_control_csharp_zoleman.Ships
{
    public abstract class ImmobileSpacecraft : Spacecraft
    {
        
        public ImmobileSpacecraft(int registrationCode, string name, int commissionYear)
            : base(registrationCode, name, commissionYear)
        { 
            CanFly = false;
        }
    }
}
