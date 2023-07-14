using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace würfel_bullshit
{
    internal class Würfel
    {
        private int MAX;
        static Random rnd = new Random();

        public Würfel()
        {
            MAX = 6;
        }

        public Würfel(int max)
        {
            if (max<2)
            {
                throw new Exception("Würfel muss mindestens 2 Seiten haben!");
            }
            MAX = max;
        }

        public int Augenzahl { get; private set; }
        public int Würfeln()
        {
            return Augenzahl = rnd.Next(1, MAX + 1);
        }
    }
}
