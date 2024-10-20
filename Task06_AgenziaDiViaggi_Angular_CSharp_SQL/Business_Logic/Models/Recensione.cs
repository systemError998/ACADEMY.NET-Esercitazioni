using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business_Logic.Models
{
    [Table("Recensione")]
    public class Recensione
    {
        [Key]
        public int RecensioneID { get; set; }

        [Column("recensioneCod")]
        public string Codice { get; set; } = null!;
        public string NomeUtente { get; set; } = null!;
        public int Voto { get; set; }
        public string? Commento { get; set; }

        [Column("data_recensione")]
        public DateTime DataRecensione { get; set; }

        [Column("pacchetto_vacanzaRIF")]
        public int PacchettoRIF { get; set; }

    }
}
