using System;
using System.Collections.Generic;

namespace Drones
{
    public class Dispatch : IDispatchable
    {
        private List<Box> boxes = new List<Box>();

        public void AddBox(Box box)
        {
            boxes.Add(box);
            Console.WriteLine($"[Dispatch] Réception de {box}");
        }

        public void RemoveBox(Box box)
        {
            boxes.Remove(box);
            Console.WriteLine($"[Dispatch] Retrait de {box}");
        }

        public List<Box> GetAllBoxes()
        {
            return new List<Box>(boxes);
        }
    }
}
