using Drones.Helpers;
using System.Drawing;
namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
       

        private int charge = 1000;                     // La charge actuelle de la batterie
        private string name;                           // Un nom
        private int x ;                                // Position en X depuis la gauche de l'espace aérien
        private int y;                                 // Position en Y depuis le haut de l'espace aérien
        private EvacuationState state;                 //L'état de l'évacuation du drone

        //Constructeur de la classe drone
        public Drone(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.state = EvacuationState.Free;
        }

        //Récupérations des propriétés du drone
        public int getXPosition
        {
            get { return x; }
            set { x = value; }
        }
        public int getYPosition
        {
            get { return y; }
            set { y = value; }
        }
      public string getName {
            get { return name; }
        set { name = value; }
        }
        public bool LowBattery
        {
            get { return charge < 200; } // 20% de 1000
        }

        //Etat d'évacuation du drone
        public bool Evacuate(Rectangle zone)
        {
            if (!zone.Contains(x, y))
            {
             
                state = EvacuationState.Evacuated;
                return true;
            }
            else
            {
                state = EvacuationState.Evacuating;
                return false;
            }
        }

        //Le vol libre du drone
        public void FreeFlight()
        {
            state = EvacuationState.Free;
        }

        //Récupération de l'état de l'évacuation du drone
        public EvacuationState GetEvacuationState()
        {
            return state;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            if (charge <= 0)
                return; // ne rien faire si la batterie est vide
            x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            y += RandomNumberHelper.Get(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
