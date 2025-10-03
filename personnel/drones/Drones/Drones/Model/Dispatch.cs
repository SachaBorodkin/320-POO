using System;
using System.Collections.Generic;

namespace Drones
{
    public class Dispatch : IDispatchable      //Application d'interface
    {
        //Liste des boxes du centre de dispatch
        private List<Box> boxes = new List<Box>();

        //Ajout du box dans centre 
        public void AddBox(Box box)
        {
            boxes.Add(box);
            Console.WriteLine($"[Dispatch] Réception de {box}");
        }

        //Suppression du box du cente 
        public void RemoveBox(Box box)
        {
            boxes.Remove(box);
            Console.WriteLine($"[Dispatch] Retrait de {box}");
        }

        //Récupération de la liste de toutes les boxes 
        public List<Box> GetAllBoxes()
        {
            return new List<Box>(boxes);
        }
    }
}
