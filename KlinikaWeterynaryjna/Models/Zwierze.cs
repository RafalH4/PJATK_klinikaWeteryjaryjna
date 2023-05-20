using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaWeterynaryjna.Models
{
    internal class Zwierze
    {
        public int IdZwierze { get; set; }
        public string Nazwa { get; set; }
        public string Gatunek { get; set; }
        public DateTime DataOstWizyty { get; set; }
        public int IdWlasciciel { get; set; }
        public string ImieWlasciciela { get; set; }
        public string NazwiskoWlasciciela { get; set; }
    }
}
