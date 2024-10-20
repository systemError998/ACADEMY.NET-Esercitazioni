using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business_Logic.Models
{
    public class DestinazionePacchettoVacanza
    {
        [Key]
        public int DestinazionePacchettoVacanzaId { get; set; }

        [Column("destinazioneRIF")]
        public int? DestinazioneRif { get; set; }

        [Column("pacchetto_vacanzaRIF")]
        public int? PacchettoVacanzaRif { get; set; }

        public virtual Destinazione? DestinazioneRifNavigation { get; set; }

        public virtual PacchettoVacanza? PacchettoVacanzaRifNavigation { get; set; }

        //public virtual ICollection<DestinazionePacchettoVacanza> DestinazionePacchettoVacanzas { get; set; } = new List<DestinazionePacchettoVacanza>();
    }
}
