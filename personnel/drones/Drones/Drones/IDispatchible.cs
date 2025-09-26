using System.Collections.Generic;

namespace Drones
{
    public interface IDispatchable
    {
        void AddBox(Box box);
        void RemoveBox(Box box);
        List<Box> GetAllBoxes();
    }
}
