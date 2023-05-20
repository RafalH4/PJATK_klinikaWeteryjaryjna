using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaWeterynaryjna.Models
{
    internal class Wlasciciel
    {
        public int IdWlasciciel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string ImieNazwisko => Imie + " " + Nazwisko;
    }
}
