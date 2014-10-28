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

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Constructor van de class Player (heeft dezelfde naam als de class en geen returntype
        // Dus ook geen void!
        public Player(string name)
        {
            this.name = name;
        }
    }
}
