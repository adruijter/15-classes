using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maak een instantie (object) van de Explorer class.

            // Stap 1. Verzin een naam van het type Explorer;
            Explorer explorer1;


            // Stap 2. Maak een nieuw object(instantie) van de class Explorer
            explorer1 = Explorer.createSingleInstance("The Axe", 10);

            Console.WriteLine("Het favoriete wapen van deze explorer is: " + explorer1.FavoriteWeapon);
            Console.WriteLine("Het aantal gedode mummies van deze explorer is: " + explorer1.KilledMummies);



            // Maak een tweede instantie (object) van de Explorer class.
            Explorer explorer2 = Explorer.createSingleInstance("The Chainsaw", 11);

            Console.WriteLine("Het favoriete wapen van deze explorer is: " + explorer2.FavoriteWeapon);
            Console.WriteLine("Het aantal gedode mummies van deze explorer is: " + explorer2.KilledMummies);



            Console.ReadLine();
        }
    }
}
