using Ispit.Model;
using System;
using System.Collections.Generic;

namespace Ispit.Konzola
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Ucenik> list = new List<Ucenik>();
            while (list.Count < 3)
            {
                Ucenik u = new Ucenik();
                Console.WriteLine($"Unesite podatke za {list.Count + 1}. učenika");

                Console.WriteLine("Ime: ");
                u.Ime = Console.ReadLine();

                Console.WriteLine("Prezime: ");
                u.Prezime = Console.ReadLine();

                Console.Write("Datum rođenja (dd/MM/yyyy): ");
                u.DatumRodjenja = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Prosjek: ");
                u.Prosjek = Convert.ToDouble(Console.ReadLine());
                
                list.Add(u);
            }
            Console.Clear();
            foreach (Ucenik u in list)
            {
                u.UcenikInfo();
            }
            Console.ReadLine();
        }
    }
}
