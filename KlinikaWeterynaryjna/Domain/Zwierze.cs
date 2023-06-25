using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Domain;

public partial class Zwierze
{
    public int IdZwierze { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Gatunek { get; set; } = null!;

    public DateTime DataOstWizyty { get; set; }

    public int IdWlasciciel { get; set; }

    public Guid Rowguid { get; set; }

    public virtual Wlasciciel IdWlascicielNavigation { get; set; } = null!;
}
