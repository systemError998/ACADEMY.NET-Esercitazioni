using Business_Logic.Models;
using Microsoft.EntityFrameworkCore;

namespace Business_Logic.Context
{
    public class LaPerlaNeraContext : DbContext
    {
        public LaPerlaNeraContext(DbContextOptions<LaPerlaNeraContext> options) : base(options)
        { }

        public DbSet<Destinazione> Destinazioni { get; set; }
        // public DbSet<PacchettoVacanza> Pacchetti_Vacanza { get; set; }
        // public DbSet<Recensione> Recensioni { get; set; }


    }
}
