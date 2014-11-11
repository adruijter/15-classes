using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OefenMetClasses
{
    public class Pizza
    {
        // Fields
        private string name;
        private float price;
        private int cut;
        private bool sauce;
        private string[] topping = new string[10];
        private bool takeAway;
        private int ovenTemperature;
        private int minutesOfKneading;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Cut
        {
            get { return this.cut; }
            set { this.cut = value; }
        }

        public bool Sauce
        {
            get { return this.sauce; }
            set { this.sauce = value; }
        }

        public string[] Topping
        {
            get { return this.topping; }
        }

        public bool TakeAway
        {
            get { return this.takeAway; }
            set { this.takeAway = value; }
        }

        public int OvenTemperature
        {
            get { return this.ovenTemperature; }
            set { this.ovenTemperature = value; }
        }

        public int MinutesOfKneading
        {
            get { return this.minutesOfKneading; }
            set { this.minutesOfKneading = value; }
        }
    
        //Constructor
        public Pizza(string name, float price, int cut, bool sauce,
                        string[] topping, bool takeAway, int ovenTemperature, int minutesOfKneading)
        {
            this.name = name;
            this.price = price;
            this.cut = cut;
            this.sauce = sauce;
            this.topping = topping;
            this.takeAway = takeAway;
            this.ovenTemperature = ovenTemperature;
            this.minutesOfKneading = minutesOfKneading;
        }

        private string SauceOrNot()
        {
            if (this.sauce)
            {
                return "wel";
            }
            else
            {
                return "geen";
            }
        }

        private string ToppingList()
        {
            string toppingList = "";
            foreach ( string topping in this.topping)
            {
                toppingList += topping + ", ";
            }
            return toppingList;
        }

        private string TakeAwayYesOrNo()
        {
            if (this.takeAway)
            {
                return "wel";
            }
            else
            {
                return "niet";
            }
        }

        public void Draw()
        {
            Console.WriteLine("U heeft de volgende pizza bestelt: " + this.name);
            Console.WriteLine("U betaalt voor deze pizza: " + this.price);
            Console.WriteLine("U wilt de pizza in {0} stukjes", this.cut);
            Console.WriteLine("U wilt {0}: tomatensaus", this.SauceOrNot());
            Console.WriteLine("U wilt als topping op de pizza: " + this.ToppingList());
            Console.WriteLine("U wilt de pizza {0} meenemen", this.TakeAwayYesOrNo());
            Console.WriteLine("Uw pizza is gebakken op {0} graden Celsius", this.ovenTemperature);
            Console.WriteLine("Uw pizzadeeg is {0} gekneed", this.minutesOfKneading);
        }
    }
}
