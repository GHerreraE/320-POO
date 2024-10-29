using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{


    class Boat : IContainer
    {

        // Propriétés du bateau
        private string _name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        private float _maxCargoWeight
        {
            get
            {
                return _maxCargoWeight;
            }
            set
            {
                _maxCargoWeight = value;
            }
        }

        private int _maxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                _maxSpeed = value;
            }
        }



        // Méthodes pour le bateau
        public void Start() // Démarrer le bateau
        { 

        }

        public bool LoadContainer(IContainer container) // Charger un container
        {

        }
           
        
        
        public bool UnloadContainer(IContainer container);  // Décharger un container
    }
}