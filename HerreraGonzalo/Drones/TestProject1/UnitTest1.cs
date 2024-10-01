using System.Text;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
           
            Drone drone = new Drone (500, 500);

           
            EvacuationState state = drone.GetEvacuationState();

            
            Assert.AreEqual(EvacuationState.Free, state);

            
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            
            drone.FreeFlight();

           
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }

    }
}