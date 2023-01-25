using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova te će svaki razmak zamijeniti znakom '_'.*/
            Console.WriteLine("Unesite niz znakovva: ");
            string niz = Console.ReadLine();
            niz = niz.Replace(" ","_");
            Console.Write(niz);
            Console.ReadKey();
        }
    }
}
