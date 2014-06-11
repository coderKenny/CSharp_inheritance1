using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_1
{
    internal class Nisakas
    {
        int ika;
        string vari, nimi;

        internal virtual void kavelee()
        {
            Console.WriteLine("Nisäkäs kävelee");
 
        }
        
        internal virtual void puhuu()
        {
            Console.WriteLine("Nisäkäs puhuu");
        }
            
        internal virtual int kertoo_ikansa()
        {
            return this.ika;
        }

        internal virtual void asettaa_ikansa(int ika)
        {
            this.ika=ika;
        }
    }
}
