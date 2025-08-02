using NUnit.Framework;
using starfleet_control_csharp_zoleman.Ships;
using starfleet_control_csharp_zoleman.DockingResults;


namespace starfleet_control_csharp_zoleman_tests
{
    [TestFixture]


    public class DiscoverShipTest
    {
        private DiscoveryShip _ship;
        private SpaceStation _station;

        [SetUp]
        public void SetUp()
        {
            _ship = new DiscoveryShip(42, "Voyager", 2100);
            _station = new SpaceStation(100, "FakesStation", 2100);
        }

        [Test]
        public void Dock_AddsDiscoveryDockingResultToPrivateLog()
        {
            _ship.Dock(_station);

            Assert.That(1, Is.EqualTo(_ship.GetDockingLog().Count));
        }

        [Test]
        public void Dock_SavesDataCorrectly()
        {
            _ship.Dock(_station);

            var result = _ship.GetDockingLog()[0] as DiscoveryDockingResult;

            Assert.That(result.StationRegistrationCode, Is.EqualTo(100));
        }
    }
}
