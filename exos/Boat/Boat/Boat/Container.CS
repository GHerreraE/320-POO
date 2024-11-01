using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{

    class Container : IContainer
    {
        // Propri�t�s du bateau
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

        private float _MaxCargoWeight
        {
            get
            {
                return _MaxCargoWeight;
            }
            set
            {
                _MaxCargoWeight = value;
            }
        }

        private int _MaxSpeed
        {
            get
            {
                return _MaxSpeed;
            }
            set
            {
                _MaxSpeed = value;
            }
        }

        // M�thodes pour le bateau
        public void Start() // D�marrer le bateau
        {


        }
        bool LoadContainer(IContainer container);  // Charger un container
        bool UnloadContainer(IContainer container);  // D�charger un container
    }
}