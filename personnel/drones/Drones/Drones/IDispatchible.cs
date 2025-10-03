
using System.Collections.Generic;

namespace Drones
{
    // Interface définissant le comportement d’un objet pouvant gérer des colis (Box)
    public interface IDispatchable
    {
        // Ajoute un colis (Box) à la collection
        void AddBox(Box box);

        // Retire un colis (Box) de la collection
        void RemoveBox(Box box);

        // Retourne la liste de tous les colis actuellement gérés
        List<Box> GetAllBoxes();
    }
}

