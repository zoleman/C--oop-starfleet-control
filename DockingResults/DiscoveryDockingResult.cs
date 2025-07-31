using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starfleet_control_csharp_zoleman.DockingResults
{
    public class DiscoveryDockingResult : DockingResult
    {
        public DateTime DockingDate { get; }
        public int StationRegistrationCode { get; }

        public DiscoveryDockingResult(int stationRegistrationCode)
        {
            DockingDate = DateTime.Now;
            StationRegistrationCode = stationRegistrationCode;
        }
    }
}
