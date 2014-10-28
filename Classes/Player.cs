using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Player
    {
        //Fields
        private string name;
        private int score;

        //Properties
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

        // Constructor van de class Player (heeft dezelfde naam als de class en geen returntype
        // Dus ook geen void!
        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
