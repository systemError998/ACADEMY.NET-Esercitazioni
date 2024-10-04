﻿using System;
using System.Collections.Generic;

namespace librioteca.Models;

public partial class Prestito
{
    public int PrestitoId { get; set; }

    public string? Codice { get; set; }

    public DateOnly DataPrestito { get; set; }

    public DateOnly? DataRitorno { get; set; }

    public int UtenteRif { get; set; }

    public int LibroRif { get; set; }

    public virtual Libro LibroRifNavigation { get; set; } = null!;

    public virtual Utente UtenteRifNavigation { get; set; } = null!;
}
