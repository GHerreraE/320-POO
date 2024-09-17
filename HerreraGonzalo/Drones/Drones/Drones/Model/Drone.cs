namespace Drones
{
    public static class RandomHelper
    {
        private static Random _alea = new Random();

        // Génère un nombre aléatoire entre min et max
        public static int GetRandom(int min, int max)
        {
            return _alea.Next(min, max);
        }
    }

    public static class Config
    {
        public const int MaxCharge = 1000;       // Charge maximale de la batterie
        public const int MovementX = 2;          // Déplacement fixe en X
        public const int MinMovementY = -2;      // Déplacement minimal en Y
        public const int MaxMovementY = 2;       // Déplacement maximal en Y
    }

    public partial class Drone
    {
        // Champs privés
        private int _charge;
        private string _name;
        private int _x;
        private int _y;

        // Constructeur pour initialiser les valeurs
        public Drone(string name)
        {
            _name = name;
            _charge = Config.MaxCharge;
            _x = 0;
            _y = 0;
        }

        // Méthodes d'accès aux valeurs encapsulées
        public int GetCharge()
        {
            return _charge;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

        // Méthode pour mettre à jour l'état du drone
        public void Update(int interval)
        {
            _x += Config.MovementX;              // Déplacement fixe en X
            _y += RandomHelper.GetRandom(Config.MinMovementY, Config.MaxMovementY + 1); // Déplacement aléatoire en Y
            _charge--;                           // Consommation d'énergie
        }
    }
}
