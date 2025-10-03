using Drones.Helpers;

namespace Drones
{
    public partial class ZavodRoshen : Building //Usine hérite de la batiment
    {
        private float _powerConsumption;                                    //Consommation de l'énergie par l'usine
        public int Id { get; private set; }                                 //Id de l'usine

        //Constructeur de la classe de l'usine(ZavodRoshen)
        /* Tut buv Poroshenko
                                                    ..                                                                     
                     :########-.    ..=#######+..   ..=#####*. .###.       +##-.:#########:.=##*..     .*#*.                    
                     .##+  ..*##.  .###=.   .-###:. :##-. .-#. .*#*.       =##: .##+.   ... .####=.     =#+                     
                     .##+    .##* :###.       .*##:.=##.   ..  .*#*.       =##: .##+        .##+###:.   =#+                     
                     .##+   .=##. +##-         .###.:###+:.    .*#*.       =##: .##+.       .##:.*##*.. =#+                     
                     .##+-=*##=. .*##.         .###...=#####+. .*#############: .########:  .##:..:###=.=#+                     
                     .##+.*##=.   +##:         .###.    ..+###..*#*.       =##: .##+        .##:.  .=###+#+                     
                     .##+  -###.  :##*.       .*##:...     :##-.*#*.       =##: .##+        .##:.    .*###+                     
                     .##+.  .*##=. .###:.....:###:..##.. ..=#*..*#*.       =##: .##+.........##:.      :##+                     
                     :##*.   .-###:  :+#######*:.  .-*#####*-. .###.       +##-.:#########+..##:.       .==                     
                     .....    ..=###-.........        .....    .....       ...............  ....          .                     
                    :##########*..:*###**- .+#############################################################*. */


        public ZavodRoshen(int powerConsumption, int x, int y, int depth, int width, int id) : base()
        {
            this._powerConsumption = powerConsumption;                                      //Attribution de la consommation lors construction
            this.Id = id;                                                                   //Attribution de l'id lors construction 
            this.x = x;                                                             //Attribution du X lors construction 
            this.y = y;                                                             //Attribution du Y lors construction 
            this.depth = depth;                                                     //Attribution du profondeur lors construction 
            this.width = width;                                                     //Attribution du largeur lors construction
            Console.WriteLine("L'usine consomme " + powerConsumption + " KwH");     //Ecriture la consommation de l'usine lors construction
        }

        //Dessin de l'usine
        public override void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(buildingBrush, new Rectangle(x, y, width, depth));
        }
        //Mise à jour de l'usine chaque frame
        public void Update(int interval)
        {
            //Compteur des frames pour production de box
            int compteur = 0;
            compteur++;
            frameCounter += interval;

            if (frameCounter >= 5000) // si c'est 5 secondes - box est produit
            {
                //Mise du compteur à 0
                frameCounter = 0;

                //Nombre alléatoire entre 5 et 10 (inclus) pour le poids
                int poids = RandomNumberHelper.Get(5, 11);
                //Liste des couleurs et choix alléatoire pour box
                string[] couleurs = { "Rouge", "Jaune", "Bleu", "Brun", "Orange" };
                Random rnd = new Random();
                //Attribution du couleur
                string couleur = couleurs[rnd.Next(couleurs.Length)];

                //Création du box 
                Box box = new Box(poids, couleur);

                //Ecriture que l'usine a produit un box
                Console.WriteLine($"[ZavodRoshen {Id}] Production : {box}");

                //Ajout du box dans le centre de dispatch
                AirSpace.DispatchCenter.AddBox(box);
            }
        }

    }
}
