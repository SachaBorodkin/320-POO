using Drones;
namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
         
                List<Drone> fleet = new List<Drone>();
         

            Drone drone = new Drone();
            drone.getXPosition = 100;
            drone.getYPosition = 100;
            drone.getName = "100% pas le drone";//"Дрон СБУ ";
            fleet.Add(drone);
            Drone drone1 = new Drone();
            fleet.Add(drone1);
            Drone drone2 = new Drone();
            fleet.Add(drone2);
            Drone drone3 = new Drone();
            fleet.Add(drone3);
            Drone drone4 = new Drone();
            fleet.Add(drone4);
            Drone drone5 = new Drone();
            fleet.Add(drone5);
            Drone drone6 = new Drone();
            fleet.Add(drone6);
            Drone drone7 = new Drone();
            fleet.Add(drone7);
            Drone drone8 = new Drone();
            fleet.Add(drone8);
            Drone drone9 = new Drone();
            fleet.Add(drone9);
            Drone drone10 = new Drone();
            fleet.Add(drone10);


            if (fleet.Count > 10)
            {
                throw new Exception("Quantité de drones est supérieure à 10");
            }
            List<Building> street = new List<Building>();
       
            ZavodRoshen Vinnytsia = new ZavodRoshen(100, 30, 30, 50, 50, 1);
            street.Add(Vinnytsia);

            ATB Zhytomyr = new ATB("Lundi-Samedi: 8h-18h", 100, 150, 100, 100);
            street.Add(Zhytomyr);

            // Démarrage
            Application.Run(new AirSpace(fleet, street));
            
        }
    }
}