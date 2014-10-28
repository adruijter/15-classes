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
            arjan = new Player("Arjen de Ruijter", 8400);
            //arjan.name = "Arjan de Ruijter";
            arjan.Name = "Arjan de Ruijter";


            bert = new Player("Bert de Vries", 200);
            //bert.name = "Bert de Vries";

            harry = new Player("Harry de Groot", 8150);
            //harry.name = "Harry de Groot";



            Console.WriteLine("{0} heeft als score: {1}", arjan.Name, arjan.Score);
            Console.WriteLine("{0} heeft als score: {1}", bert.Name, bert.Score);
            Console.WriteLine("{0} heeft als score: {1}", harry.Name, harry.Score);
            Console.ReadLine();
        }
    }
}
