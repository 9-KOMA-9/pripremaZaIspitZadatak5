
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVijezba05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napišite program koji će zatražiti od korisnika da unese neku rečenicu te će ispisati prvu i zadnju riječ te rečenice.
            Console.WriteLine("Upišite nekakvu rečenicu: ");
            string tekst = Console.ReadLine();
            string[] rijeci = tekst.Split(' ');
            if(rijeci.Length >= 2 )
            {
                Console.WriteLine("prva rijec je: " + rijeci[0]);
                Console.WriteLine("zadnja rijec je: " + rijeci[rijeci.Length - 1]);

            }
            else
            {
                Console.WriteLine("Upišite barem dvije rijeci.");
            }

            Console.ReadKey();
        }
    }
}
