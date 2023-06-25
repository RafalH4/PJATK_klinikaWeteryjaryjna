using System;
using System.Collections.Generic;

namespace KlinikaWeterynaryjna.Domain;

public partial class Uzytkownik
{
    public int IdUzytkownik { get; set; }

    public string Email { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Haslo { get; set; } = null!;
}
