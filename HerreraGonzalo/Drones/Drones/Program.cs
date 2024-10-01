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
            List<Buliding> bulidings = new();
            List<Factory> factorys = new List<Factory>();
            List<Store> stores = new List<Store>();
            Drone drone = new Drone();
            Buliding buliding = new Buliding();
            Buliding buliding2 = new Buliding();
            Factory factory = new Factory();
            Store store = new Store();

            drone.x = 200;
            drone.y = 100;
            drone.name = "gonzalo";

            fleet.Add(drone);

            bulidings.Add(buliding);
            bulidings.Add(buliding2);
          
            factorys.Add(factory);
            stores.Add(store);

            buliding.x = 400;
            buliding.y = 100;


            buliding2.y = 70;
            buliding2.x = 410;

            factory.y = 450;
            factory.x = 50;
            

            store.y = 130;
            store.x = 490;



            Drone drone2 = new Drone();
            drone2.name = "samuel";
            drone2.x = 200;
            drone2.y = 500;
            

            Drone drone3 = new Drone();
            drone3.name = "thomas";
            drone3.x = 200;
            drone3.y = 200;

            Drone drone4 = new Drone();
            drone4.name = "alexander";
            drone4.x = 200;
            drone4.y = 300;
            

            fleet.Add(drone2);
            fleet.Add(drone3);
            fleet.Add(drone4);
         

            try
            {
                if(fleet.Count() >= 10)
                {
                    throw new Exception("La valeur du fleet doit être inférieure à 10");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet,bulidings,factorys,stores));

            Rectangle r1 = new Rectangle(10, 10, 100, 150);
            Rectangle r2 = new Rectangle(30, 100, 150, 100);
            Rectangle r3 = new Rectangle(200, 300, 50, 50);

            r1.IntersectsWith(r2); // true
            r1.IntersectsWith(r3); // false
        }
    }
}