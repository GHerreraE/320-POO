using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte_Bancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account cuenta = new Account(1,2,"hola");
            cuenta.ShowAmount();
        }
    }
}
