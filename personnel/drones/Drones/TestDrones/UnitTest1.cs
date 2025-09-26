using System.Runtime.CompilerServices;
using System.Text;
using Drones;
namespace Drones
{
    [TestClass]
    public class DroneTests
    {

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