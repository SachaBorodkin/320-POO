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
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.getXPosition = 100;
            drone.getYPosition = 100;
            drone.getName = "Дрон СБУ ";
            fleet.Add(drone);

            List<Building> street = new List<Building>();
       
            ZavodRoshen Vinnytsia = new ZavodRoshen(100, 30, 30, 10, 10);
            Vinnytsia.setBuildingXPosition = 30;
            Vinnytsia.setBuildingYPosition=30;
            Vinnytsia.getsetDepth=10;
            Vinnytsia.getsetWidth=10;
            street.Add(Vinnytsia);

            ATB Zhytomyr = new ATB("Lundi-Samedi: 8h-18h", 100, 150, 100, 100);
            street.Add(Zhytomyr);

            // Démarrage
            Application.Run(new AirSpace(fleet, street));
            
        }
    }
}