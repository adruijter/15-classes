using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Player arjan, bert, harry;

            // Geef aan de constructor de naam mee
            arjan = new Player("Arjen de Ruijter");
            //arjan.name = "Arjan de Ruijter";
            arjan.Name = "Arjan de Ruijter";


            bert = new Player("Bert de Vries");
            //bert.name = "Bert de Vries";

            harry = new Player("Harry de Groot");
            //harry.name = "Harry de Groot";



            Console.WriteLine("{0} heeft als score: {1}", arjan.Name, 4500);
            Console.WriteLine("De naam opgeslagen in het object bert is: {0}", bert.Name);
            Console.WriteLine("De naam opgeslagen in het object harry is: {0}", harry.Name);
            Console.ReadLine();
        }
    }
}
