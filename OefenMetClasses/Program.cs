using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OefenMetClasses
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Pizza margharita;
            margharita = new Pizza("Margharita",
                                    8.56f,
                                    8,
                                    false,
                                    new string[] { "Basilicum", "Mozzarella" },
                                    false,
                                    395,
                                    20);

            margharita.Draw();
            Console.ReadLine();
        }
    }
}
