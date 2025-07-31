namespace starfleet_control_csharp_zoleman.Ships
{
    public abstract class Spacecraft
    {
        
        public int RegistrationCode { get; }
        public string Name { get; }
        public int CommissionYear { get; }
        protected bool CanFly;

        public Spacecraft(int registrationCode, string name, int commissionYear) 
        {
            RegistrationCode = registrationCode;
            Name = name;
            CommissionYear = commissionYear;
        }
    }
}
