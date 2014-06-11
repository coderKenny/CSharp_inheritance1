using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
    internal class Koira:Nisakas
    {
        string omistaja;

        internal override void kavelee()
        {
            Console.WriteLine("Koira kävelee");
        }

        internal override int kertoo_ikansa()
        {
            return base.kertoo_ikansa();
        }
        
        internal override void puhuu()
        {
            Console.WriteLine("Koira haukkuu");
        }

        internal string kertoo_omistajansa()
        {
            return this.omistaja;
        }

        internal void asettaa_omistajansa(string omistaja)
        {
            this.omistaja=omistaja;
        }
    }
}
