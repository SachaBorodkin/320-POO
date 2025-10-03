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
        private static int globalId = 0;            //Id du box
        public int Id { get; private set; }         //Id du box publique
        public int PoidsKg { get; private set; }    //Poids du box publique
        public string Couleur { get; private set; } //Couleur de box

        //Constructeur te la classe Box
        public Box(int poidsKg, string couleur)
        {
            Id = ++globalId;            //Incrément du Id du box
            PoidsKg = poidsKg;          //Attribution d'une valeur pour le poids
            Couleur = couleur;          //Attribution d'une valeur pour le couleur
        }

        //Création du message de production d'un box
        public override string ToString()
        {
            return $"Box {Id} : {PoidsKg} kg de smarties {Couleur}";
        }

    }
}
