using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drones.Helpers;
using Drones;
namespace Drones
{
    public class Box
    {
        private static int globalId = 0;

        public int Id { get; private set; }
        public int PoidsKg { get; private set; }
        public string Couleur { get; private set; }

        public Box(int poidsKg, string couleur)
        {
            Id = ++globalId;
            PoidsKg = poidsKg;
            Couleur = couleur;
        }

        public override string ToString()
        {
            return $"Box {Id} : {PoidsKg} kg de smarties {Couleur}";
        }

    }
}
