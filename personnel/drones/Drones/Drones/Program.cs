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
            Building building = new Building();
            building.getBuildingXPosition = 0;
            building.getBuildingYPosition = 100;
            building.getDeepth = 100;
            building.getWidth = 100;
            street.Add(building);
       

            // Démarrage
            Application.Run(new AirSpace(fleet, street));
            
        }
    }
}