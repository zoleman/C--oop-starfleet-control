using starfleet_control_csharp_zoleman.DockingResults;

namespace starfleet_control_csharp_zoleman.Ships
{
    public abstract class MobileSpacecraft : Spacecraft
    {
        public int MaxSpeed { get; private set; }
        private bool isDocked = false;


        public MobileSpacecraft(int registrationCode, string name, int commissionYear, int baseSpeed) 
            : base(registrationCode, name, commissionYear) 
        {

            MaxSpeed = baseSpeed;
            CanFly = true;
            if (commissionYear < 2150)
            {
                MaxSpeed = MaxSpeed - 30;
            }
            else if (commissionYear > 2200)
            {
                MaxSpeed = MaxSpeed + 15;
            }
        }

        public abstract void Dock(SpaceStation station);
        
    }
}
