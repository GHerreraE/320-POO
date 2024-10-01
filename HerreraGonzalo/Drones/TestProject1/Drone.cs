
using System.Drawing;

namespace TestProject1
{
    internal class Drone
    {
        private int v1;
        private int v2;

        public Drone(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal bool Evacuate(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        internal void FreeFlight()
        {
            throw new NotImplementedException();
        }

        internal EvacuationState GetEvacuationState()
        {
            throw new NotImplementedException();
        }
    }
}