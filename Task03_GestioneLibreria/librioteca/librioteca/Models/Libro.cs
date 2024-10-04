using System;
using System.Collections.Generic;

namespace librioteca.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string? Codice { get; set; }

    public string Titolo { get; set; } = null!;

    public string Autore { get; set; } = null!;

    public int Anno { get; set; }

    public bool? Disponibile { get; set; }

    public virtual ICollection<Prestito> Prestitos { get; set; } = new List<Prestito>();
}
