using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Domain;

public partial class Wlasciciel
{
    public int IdWlasciciel { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public Guid Rowguid { get; set; }

    public virtual ICollection<Zwierze> Zwierzes { get; set; } = new List<Zwierze>();
}
