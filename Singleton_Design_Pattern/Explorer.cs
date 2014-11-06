using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton_Design_Pattern
{
    public class Explorer
    {
        // Maak de twee private fields geschikt voor deze explorer class
        private string favoriteWeapon;
        private int killedMummies;
        private static Explorer explorer;

        // Maak voor de twee bovenstaande fields twee properties(getter en setter)
        public string FavoriteWeapon
        {
            get { return this.favoriteWeapon; }
            set { this.favoriteWeapon = value; }
        }

        public int KilledMummies
        {
            get { return this.killedMummies; }
            set { this.killedMummies = value; }
        }

        // Maak de constructor van deze class.
        private Explorer(string favoriteWeapon, int killedMummies)
        {
            this.favoriteWeapon = favoriteWeapon;
            this.killedMummies = killedMummies;
        }

        public static Explorer createSingleInstance(string favoriteWeapon, int killedMummies)
        {
            if ( explorer == null)
            {
                explorer = new Explorer(favoriteWeapon, killedMummies);
            }
            return explorer;
        }

    }
}
