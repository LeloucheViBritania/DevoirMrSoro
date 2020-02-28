using System;

namespace exoSoro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool etatGlace;
            bool etatLiquide;
            Console.WriteLine("Entrez une température : ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp >= 1 && temp <= 100)
            {
                etatGlace = false;
                etatLiquide = true;
                Console.WriteLine("L'eau est l'état Liquide");  
            }

            if(temp <= 0 )
            {
                etatGlace = true;
                etatLiquide = false;
                Console.WriteLine("L'eau est l'état de Glace");
            }

            if(temp > 100)
            {
                etatGlace = false;
                etatLiquide = false;
                Console.WriteLine("L'eau est l'état de Vapeur");
            }

           
            
        }
    }
}
