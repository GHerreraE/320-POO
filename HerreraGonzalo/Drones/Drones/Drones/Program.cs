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
            Drone drone = new();
            drone.x = 100;
            drone.y = 100;
            drone.name = "Joe";
            fleet.Add(drone);

            List<Building> flotte = new List<Building> { };
            Building immeuble1 = new Building(1, 2, 3, 4, "hola");
            Building immeuble2 = new Building(3, 4, 5, 6, "ciao");

            flotte.Add(immeuble1);
            flotte.Add(immeuble2);



            // Démarrage
            Application.Run(new AirSpace(fleet));


            
        }
    }
}