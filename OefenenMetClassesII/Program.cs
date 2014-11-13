using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OefenenMetClassesII
{
    
    public enum BeanSpecies { Aribica, Robusta, Liberica };
    public enum Milk { Fat, LowFat, Skimmed };
    public enum Sweetening { Sugar, Honey, NoCalories };

    public class Program
    {
        

        static void Main(string[] args)
        {
            List<Coffee> koffieLijst;
            Coffee eersteKoffie, tweedeKoffie;

            koffieLijst = new List<Coffee>();
            koffieLijst.Add(eersteKoffie = new Coffee());
            koffieLijst.Add(tweedeKoffie = new Coffee());
            
            // Veranderen van koffie eigenschappen in de lijst
            koffieLijst[0].Cream = false;
            eersteKoffie.Cookie = false;

            koffieLijst[1].MilkWhipped = false;
            tweedeKoffie.Sweet = Sweetening.NoCalories;

            // Maken van een object met een argumentloze constructor
            Coffee koffie00 = new Coffee();
            
            // Maken van een object met een overladen constructor
            Coffee koffie01 = new Coffee(Sweetening.NoCalories,
                                         "Ethiopie",
                                         BeanSpecies.Liberica,
                                         Milk.LowFat,
                                         false,
                                         true,
                                         false);
            
            // Weergeven op het scherm van de koffie objecten.
            koffie00.Draw();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            koffie01.Draw();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Coffee koffie in koffieLijst)
            {
                koffie.Draw();
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            
            /* Maak een class Coffee
             * Fields
             * ++++++
             * originBeans (country)
             * beanSpieces (Arabica, robusta, liberica) enum!
             * milk (fat, low, skimmed) enum!
             * milkWhipped
             * sweetening (sugar, honey, noCalories) enum! 
             * cream
             * cookie
             * 
             * Maak properties voor elk field (get en set)
             * 
             * Maak een constructor die alle fields een beginwaarde geeft.
             * 
             * Maak een Draw() method die alle fieldvalues kan weergeven op het scherm.
             */
            Console.ReadLine();
        }
    }
}
