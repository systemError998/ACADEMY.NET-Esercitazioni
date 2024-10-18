using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Business_Logic.Models
{
    [Table("Destinazione")]
    public class Destinazione
    {
        [JsonIgnore]
        public int DestinazioneID { get; set; }
        public string DestinazioneCOD { get; set; } = null!;
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public string? Paese { get; set; }
        public string? Copertina { get; set; }
    }
}
