using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public Ucenik() { }
        public string Starost()
        {
            TimeSpan TS = DateTime.Today - DatumRodjenja;
            int x = (int)TS.TotalMinutes;

            int dani = (int)x / 1440;
            int mjeseci = dani / 30;
            int ostatakMjeseca = mjeseci % 12;
            int godineukupno = mjeseci / 12;
            return $"{godineukupno} godina i {ostatakMjeseca} mjeseci";
        }

        public void IspisProsjeka()
        {
            if(Prosjek > 1 && Prosjek <= 1.49)
            {
                Console.WriteLine("Nedovoljan - {0}", Prosjek);
            }
            else if(Prosjek >= 1.50 && Prosjek <= 2.49)
            {
                Console.WriteLine($"Dovoljan - {Prosjek}");
            }
            else if (Prosjek >= 2.50 &&  Prosjek <= 3.49)
            {
                Console.WriteLine($"Dobar - {Prosjek}");
            }
            else if (Prosjek >= 3.50 && Prosjek <= 4.49)
            {
                Console.WriteLine($"Vrlo dobar - {Prosjek}");
            }
            else if (Prosjek >= 4.50 && Prosjek <= 5.00)
            {
                 Console.WriteLine($"Odličan - {Prosjek}");             
            }
            else
            {
                Console.WriteLine($"Nepravilan prosjek - {Prosjek}");
            }
        }

        public void UcenikInfo()
        {
            Console.WriteLine($"{Ime} {Prezime}");
            IspisProsjeka();
            Console.WriteLine(Starost());
        }
    }
}
