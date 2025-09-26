using Drones;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
namespace Drones
{
    [TestClass]
    public class DroneTests
    {
        [TestClass]
        public class DroneUnitTests
        {
            [TestMethod]
            public void NewDrone_HasFullCharge()
            {
                var drone = new Drone(0, 0);
                var chargeField = typeof(Drone).GetField("charge", BindingFlags.NonPublic | BindingFlags.Instance);
                int charge = (int)chargeField.GetValue(drone);
                Assert.AreEqual(1000, charge);
            }

            [TestMethod]
            public void Update_DecreasesCharge()
            {
                var drone = new Drone(0, 0);
                drone.Update(100);
                var chargeField = typeof(Drone).GetField("charge", BindingFlags.NonPublic | BindingFlags.Instance);
                int charge = (int)chargeField.GetValue(drone);
                Assert.IsTrue(charge < 1000);
            }

            [TestMethod]
            public void LowBattery_IsTrue_WhenChargeBelow20Percent()
            {
                var drone = new Drone(0, 0);
                var chargeField = typeof(Drone).GetField("charge", BindingFlags.NonPublic | BindingFlags.Instance);
                chargeField.SetValue(drone, 199); // moins de 20%
                Assert.IsTrue(drone.LowBattery);
            }

            [TestMethod]
            public void Update_HasNoEffect_WhenBatteryIsZero()
            {
                var drone = new Drone(0, 0);
                var chargeField = typeof(Drone).GetField("charge", BindingFlags.NonPublic | BindingFlags.Instance);
                chargeField.SetValue(drone, 0);

                int xBefore = drone.getXPosition;
                int yBefore = drone.getYPosition;

                drone.Update(100);

                Assert.AreEqual(xBefore, drone.getXPosition);
                Assert.AreEqual(yBefore, drone.getYPosition);
            }
        }
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }
    }
    [TestClass]
    public class DispatchTests
    {
        [TestMethod]
        public void TestAddBox()
        {
            Dispatch dispatch = new Dispatch();
            Box box = new Box(7, "Rouge");

            dispatch.AddBox(box);

            Assert.AreEqual(1, dispatch.GetAllBoxes().Count);
        }

        [TestMethod]
        public void TestRemoveBox()
        {
            Dispatch dispatch = new Dispatch();
            Box box = new Box(7, "Bleu");

            dispatch.AddBox(box);
            dispatch.RemoveBox(box);

            Assert.AreEqual(0, dispatch.GetAllBoxes().Count);
        }
    }
}