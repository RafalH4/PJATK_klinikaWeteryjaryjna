using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Domain;

public partial class ZwierzetaZwlascicielami
{
    public int IdZwierze { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Gatunek { get; set; } = null!;

    public DateTime DataOstWizyty { get; set; }

    public int IdWlasciciel { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }
}
