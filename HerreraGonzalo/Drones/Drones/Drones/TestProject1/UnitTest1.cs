using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            int numberDix = 10;
            int numberZero = 0;
            int result = 0;
            
            result = Sum(numberDix, numberZero);
            if (result == 0)
            {
                Console.WriteLine("Lé resultat correct");
            }

            
        }

        public stait int Sum(int a, int b)
        {
            return a+b;
        }
    }
}