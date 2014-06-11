using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Luokkaharjoitus 1
//Tehtävässä tutustutaan luokkiin sekä perintään.

//Luodaan kolme luokkaa. Nisakas, Kissa ja Koira.
//Nisakas luokassa on seuraavat jäsenmuuttujat: 
//    ika, vari ja nimi
//Nisakas luokassa on seuraavat jäsenfunktiot: 
//    kavelee, puhuu ja kertoo_ikansa
//Kissa luokassa on seuraavat jäsenmuuttujat:
//    rotu
//Kissa luokassa on seuraavat jäsenfunktiot: 
//    kavelee, puhuu, kertoo_rotunsa ja kertoo_ikänsä
//Koira luokassa on seuraavat jäsenmuuttujat:
//    omistaja
//Kissa luokassa on seuraavat jäsenfunktiot: 
//    kavelee, puhuu, kertoo_omistajansa ja kertoo_ikänsä.
//Kissa ja koira ovat nisäkäs luokan lapsiluokkia.
//Tee pääohjelma, jossa valinnan mukaan luodaan joko nisakas, kissa tai koira. Tämän jälkeen käyttäjä voi valintansa mukaan kutsua jokaista kyseisen luokan jäsenfunktiota.




namespace Inheritance_1
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int valinta=0, valinta2=0;
            Console.WriteLine("Mikä olio luodaan 1. Nisäkäs, 2. Kissa, 3 Koira :");

            valinta=int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 1:

                    Nisakas nisakas = new Nisakas();
                    Console.WriteLine("Mitä jäsenfunktiota kutsutaan :");
                    Console.WriteLine("1. kavelee");
                    Console.WriteLine("2. puhuu");
                    nisakas.asettaa_ikansa(10);
                    Console.WriteLine("3. kertoo_ikansa");

                    valinta2 = int.Parse(Console.ReadLine());

                    switch (valinta2)
                    {
                        case 1:
                            nisakas.kavelee();
                            break;

                        case 2:
                            nisakas.puhuu();
                            break;

                        case 3:
                            Console.WriteLine("Olen "+nisakas.kertoo_ikansa()+" vuotta vanha !");
                            break;

                        default:
                            Console.WriteLine("Virhetilanne !");
                            break;
                    }
                    break;

                case 2:
                    Nisakas kissa = new Kissa();
                    Console.WriteLine("Mitä jäsenfunktiota kutsutaan :");
                    Console.WriteLine("1. kavelee");
                    Console.WriteLine("2. puhuu");
                    kissa.asettaa_ikansa(15);
                    Console.WriteLine("3. kertoo_ikansa");
                    Console.WriteLine("4. kertoo_rotunsa");
                    (kissa as Kissa).asettaa_rotunsa("Maatiaiskissa");

                    valinta2 = int.Parse(Console.ReadLine());

                    switch (valinta2)
                    {
                        case 1:
                            kissa.kavelee();
                            break;

                        case 2:
                            kissa.puhuu();
                            break;

                        case 3:
                            Console.WriteLine("Olen "+kissa.kertoo_ikansa()+" vuotta vanha !");
                            break;

                        case 4:
                            Console.WriteLine("Olen " +(kissa as Kissa).kertoo_rotunsa() + " rodultani !");
                            break;

                        default:
                            Console.WriteLine("Virhetilanne !");
                            break;
                    }
                    break;

                case 3:
                    Nisakas koira = new Koira();
                    Console.WriteLine("Mitä jäsenfunktiota kutsutaan :");
                    Console.WriteLine("1. kavelee");
                    Console.WriteLine("2. puhuu");
                    koira.asettaa_ikansa(20);
                    Console.WriteLine("3. kertoo_ikansa");
                    Console.WriteLine("4. kertoo_omistajansa");
                    (koira as Koira).asettaa_omistajansa("Jeppe Koiranomistaja");

                    valinta2 = int.Parse(Console.ReadLine());

                    switch (valinta2)
                    {
                        case 1:
                            koira.kavelee();
                            break;

                        case 2:
                            koira.puhuu();
                            break;


                        case 3:
                            Console.WriteLine("Olen " + koira.kertoo_ikansa() + " vuotta vanha !");
                            break;


                        case 4:
                            Console.WriteLine("Omistajani on " + (koira as Koira).kertoo_omistajansa());
                            break;

                        default:
                            Console.WriteLine("Virhetilanne !");
                            break;
                    }

                    break;

                default:
                    Console.WriteLine("Virhetilanne !");
                    break;
            }

            Apuluokka.Pause();
        }
    }
}
