using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Bebek bebek1 = new Bebek();
            bebek1.BebekBilgileri();

           
            Bebek bebek2 = new Bebek("Çağatay", "Kızıl");
            bebek2.BebekBilgileri();
        }
    }
}
