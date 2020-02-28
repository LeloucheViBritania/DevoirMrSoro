using System;

namespace appMrSoro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entrer un le nom du conducteur svp: ");
            Console.WriteLine("Entrer l'age: ");
            var agestring = Console.ReadLine();
            Console.WriteLine("Avez vous deja fait un accident? VEuillez indiquez le nombre: ");
            var acident = Console.ReadLine();
            Console.WriteLine("La duree de du permis svp? : ");
            var duree = Console.ReadLine();
            var dureeSur = Convert.ToInt32(duree);
            
            var accidentON = Convert.ToInt32(acident);
            var age = Convert.ToInt32(agestring);

            if (age < 25 && dureeSur < 2)
            {
                if(accidentON == 0)
                {
                    Console.WriteLine("La couleur de votre carte fidelite est de tarif rouge");
                }
                else
                    Console.WriteLine("Desole nous ne pouvons pas vous accordez l'assurance dans notre agence");

            }
            if( (age < 25 && dureeSur > 2)|| (age > 25 && accidentON < 2) )
            {
                if(accidentON ==1)
                {
                    Console.WriteLine("La couleur de votre carte fidelite est de tarif orange");
                }
                else
                    Console.WriteLine("La couleur de votre carte fidelite est de tarif rouge");
            }
            else
                Console.WriteLine("Desole nous ne pouvons pas vous accordez l'assurance dans notre agence");

            if (age > 25 && dureeSur > 2)
            {
                if (accidentON == 0)
                {
                    Console.WriteLine("La couleur de votre carte fidelite est de tarif vert");
                }
                else if (accidentON == 1)
                {
                    Console.WriteLine("La couleur de votre carte fidelite est de tarif orange");
                }
                else if( accidentON == 2)
                {
                    Console.WriteLine("La couleur de votre carte fidelite est de tarif rouge");
                }
                else if(accidentON > 2)
                {
                    Console.WriteLine("LDesole nous ne pouvons pas vous accordez l'assurance dans notre agence");
                }
            
            }
           
        }
    }
}