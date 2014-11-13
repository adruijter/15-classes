using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OefenenMetClassesII
{
    
    public class Coffee
    {
        // Fields
        private Sweetening sweet = Sweetening.Honey;
        private string originBeans = "Guatamala";
        private BeanSpecies beanSpecies = BeanSpecies.Aribica;
        private Milk milk = Milk.Skimmed;
        private bool milkWhipped = true;
        private bool cream = true;
        private bool cookie = true;

        // Properties
        public Sweetening Sweet
        {
            get { return this.sweet; }
            set { this.sweet = value;  }
        }
        public string OriginBeans
        {
            get { return this.originBeans; }
            set { this.originBeans = value; }
        }
        public BeanSpecies BeanSpecies
        {
            get { return this.beanSpecies; }
            set { this.beanSpecies = value; }
        }
        public Milk Milk
        {
            get { return this.milk; }
            set { this.milk = value; }
        }
        public bool MilkWhipped
        {
            get { return this.milkWhipped; }
            set { this.milkWhipped = value; }
        }
        public bool Cream
        {
            get { return this.cream; }
            set { this.cream = value; }
        }
        public bool Cookie
        {
            get { return this.cookie; }
            set { this.cookie = value; }
        }


        // Constructor
        public Coffee() 
        { 
        
        }

        public Coffee(Sweetening sweet, string originBeans, BeanSpecies beanSpecies, Milk milk,
                         bool milkWhipped, bool cream, bool cookie)
        {
            this.sweet = sweet;
            this.originBeans = originBeans;
            this.beanSpecies = beanSpecies;
            this.milk = milk;
            this.milkWhipped = milkWhipped;
            this.cream = cream;
            this.cookie = cookie;
        }

        private string MilkWhippedYesOrNo()
        {
            return ( this.milkWhipped ) ? "" : " niet";
        }

        private string MilkSort()
        {
            switch (this.milk)
            {
                case Milk.Fat:
                    return "volle";
                case Milk.LowFat:
                    return "halfvolle";
                case Milk.Skimmed:
                    return "magere";
                default:
                    return "";
            }
        }

        private string SweetSort()
        {
            switch (this.sweet)
            {
                case Sweetening.Honey:
                    return "honing";
                case Sweetening.NoCalories:
                    return "een zoetje";
                case Sweetening.Sugar:
                    return "suiker";
                default:
                    return "";
            }
        }

        private string CreamYesOrNo()
        {
            if (this.cream)
            {
                return "U krijgt slagroom op uw koffie. ";
            }
            else
            {
                return "";
            }
        }

        private string CookieYesOrNO()
        {
            return (this.cookie) ? "U krijgt een lekker koekje" : "";
        }

        public void Draw()
        {
            System.Console.WriteLine("U heeft een kopje koffie bestelt met {0} bonen afkomstig uit {1} \n" + 
                                     "U heeft gekozen voor {2} melk en deze is{3} opgeklopt. U gebruikt {4}\n" +
                                     "{5}{6}", this.beanSpecies, 
                                                this.originBeans, 
                                                this.MilkSort(), 
                                                this.MilkWhippedYesOrNo(),
                                                this.SweetSort(),
                                                this.CreamYesOrNo(),
                                                this.CookieYesOrNO());
        }
    }
}
