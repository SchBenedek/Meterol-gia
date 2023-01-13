using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meterológia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok feladat = new Feladatok("tavirathu13.txt");

            Console.WriteLine("2. Feladat: \n\tKérem adjon meg egy városkódot: ");
            Console.WriteLine("\t" + feladat.UtolsoMeresiAdatIdopontja(Console.ReadLine()));
            feladat.feladat03();
            Console.WriteLine("4. feladat:");
            foreach(var item in feladat.feladat04())
            {
                Console.WriteLine(item);
            }
            

            Console.ReadLine();
        }
    }
}
