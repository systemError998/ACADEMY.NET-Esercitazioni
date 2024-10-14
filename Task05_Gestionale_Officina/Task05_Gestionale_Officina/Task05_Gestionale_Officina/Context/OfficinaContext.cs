using Microsoft.EntityFrameworkCore;
using Task05_Gestionale_Officina.Models;

namespace Task05_Gestionale_Officina.Context
{
    public class OfficinaContext : DbContext
    {
        public OfficinaContext(DbContextOptions<OfficinaContext> options) : base(options)
        { 
            
        }

        //Se non specifico il modificatore d'accesso di default sarà PRIVATE
        // DbSet<Cliente> Clienti { get; set; }

        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Veicolo> Veicoli { get; set; }


    }
}
