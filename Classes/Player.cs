using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Player
    {
        //Fields zijn worden altijd private gehouden
        private static int amountOfObjects = 0;
        private string name;
        private int score;

        //Properties zijn altijd public
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public static int AmountOfObjects
        {
            get { return Player.amountOfObjects; }
            set { Player.amountOfObjects = value; }
        }



        // Constructor van de class Player (heeft dezelfde naam als de class en geen returntype
        // Dus ook geen void!
        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
            Player.amountOfObjects += 1;
        }

        public string Draw()
        {
            string tekst = "";
            tekst += "Mijn naam is " + this.name + 
                        " en ik heb in dit spel een score van: " + this.score + "\n" + this.Cheer();
            return tekst;
        }

        // < 500 => Je bent nog een Noob, >500 en < 1000 => ga zo door
        // >1000 en < 1500 het begint er op te lijken, verzin nog twee teksten
        private string Cheer()
        {
            string text = "";

            if (this.score < 500)
            {
                text += "Conclusie: Je bent niet zo goed!";
            }
            else if (this.score >= 500 && this.score < 1000)
            {
                text += "Conclusie: Ga zo door";
            }
            else if (this.score >= 1000 && this.score < 1500)
            {
                text += "Conclusie: Het begint er op te lijken";
            }
            else if (this.score >= 1500 && this.score < 2000)
            {
                text += "Conclusie: Dit gaat prima!";
            }
            else if (this.score >= 2000 && this.score < 2500)
            {
                text += "Conclusie: Je bent een professional";
            }
            else
            {
                text += "Je behoort tot de buitencategorie";
            }
            return text;
        }

        public void ScorePlus(int points)
        {
            Console.Clear();
            if (this.score < 5000)
            {
                this.score += points;
            }
            Console.WriteLine(this.Draw());
        }

        public void ScoreMinus(int points)
        {
            Console.Clear();
            if (this.score > 0)
            {
                this.score -= points;
            }
            Console.WriteLine(this.Draw());
        }

        public static void IncreaseAmountOfObjects()
        {
            Console.Clear();
            if (amountOfObjects < 42)
            {
                Player.amountOfObjects += 1;
            }
            Console.WriteLine("Het aantal objecten bedraagt nu: " 
                                    + Player.amountOfObjects.ToString());
        }

        public static void DecreaseAmountOfObjects()
        {
            Console.Clear();
            if (amountOfObjects > 0)
            {
                Player.amountOfObjects -= 1;
            }
            Console.WriteLine("Het aantal objecten bedraagt nu: "
                                    + Player.amountOfObjects.ToString());

        }
    }
}
