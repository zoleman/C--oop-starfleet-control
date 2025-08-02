using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using starfleet_control_csharp_zoleman.Ships;

namespace starfleet_control_csharp_zoleman_tests
{
    public class CargoShipTest
    {
        private CargoShip _ship;
        private SpaceStation _station;

        [SetUp]
        public void SetUp() 
        {
            _ship = new CargoShip(150, "FakeCargoShip", 2250);
            _station = new SpaceStation(155, "FakeStation", 2200);
        }

        [Test]
        public void PickUpNewCargo_SetsValidCargoAmount()
        { 
            Assert.That(_ship.CargoAmount, Is.InRange(0, 5));
        }

        [Test]
        public void PickUpNewCargo_SetsValidCargoType()
        {
            Assert.That(_ship.CargoBay[0], Is.AnyOf(
                CargoShip.CargoType.Food,
                CargoShip.CargoType.Medicine,
                CargoShip.CargoType.Weapons
            ));
        }

        [Test]
        public void Dock_WritesExpectedOutput()
        {
            var sw = new StringWriter();
            Console.SetOut(sw);

            _ship.Dock(_station);

            var output = sw.ToString();
            Assert.That(output, Does.Contain("Dropping off"));
        }

    }
}
