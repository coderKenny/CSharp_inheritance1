using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
    internal class Kissa:Nisakas
    {

        string rotu;

        internal override void kavelee()
        {
            Console.WriteLine("Kissa kävelee");

        }

        internal override void puhuu()
        {
            Console.WriteLine("Kissa maukuu");
        }

        internal override int kertoo_ikansa()
        {
            return base.kertoo_ikansa();
        }

        internal string kertoo_rotunsa()
        {
            return this.rotu;
        }

        internal void asettaa_rotunsa(string rotu)
        {
            this.rotu = rotu;
        }
    }
}
