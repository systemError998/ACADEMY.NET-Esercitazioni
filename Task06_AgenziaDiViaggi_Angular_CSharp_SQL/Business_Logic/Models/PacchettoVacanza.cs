using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business_Logic.Models
{
    [Table("Pacchetto_Vacanza")]
    public class PacchettoVacanza
    {
        [Key]
        public int PacchettoId { get; set; }
        [Column("pacchettoCOD")]
        public string Codice { get; set; } = null!;
        public string? Nome { get; set; }
        public int Prezzo { get; set; }
        public int Durata { get; set; }
        public DateTime Data_Inizio { get; set; }
        public DateTime Data_Fine { get; set; }

        // public virtual ICollection<DestinazionePacchettoVacanza> DestinazionePacchettoVacanzas { get; set; } = new List<DestinazionePacchettoVacanza>();
        
        // da errore 
        // public virtual ICollection<Recensione> Recensiones { get; set; } = new List<Recensione>();

    }
}
