using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite podatke o uceniku: ");
            Console.WriteLine("Ime ucenika: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Datum rodjenja: " );
            DateTime datumRodenja = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Naziv skole: ");
            string skola = Console.ReadLine();
            Console.WriteLine("Razred: ");
            int razred = int.Parse(Console.ReadLine());

            Ucenik ucenik = new Ucenik(ime, datumRodenja, skola, razred);

            Console.WriteLine("Unesite naziv fajla za serijalizaciju: ");
            string nazivFajla = Console.ReadLine();

            Metode.Serijalizuj(nazivFajla, ucenik);

            Ucenik ucenikDeserijalizovan = Metode.Deserijalizuj(nazivFajla);

            Console.WriteLine(ucenikDeserijalizovan);

        }
    }
}
