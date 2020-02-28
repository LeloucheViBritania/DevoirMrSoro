using System;

namespace appMrSoso3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double s = 0;
            int n = 1;
            Console.WriteLine("Entrer un nombre");
            var numberUser = Console.ReadLine();
            var numUserSur = Convert.ToDouble(numberUser);           
            while(s <= numUserSur)
            {
                
                s += (double)1 / n;
                n += 1;

            }
            Console.WriteLine(n);
            

        }
    }
}
