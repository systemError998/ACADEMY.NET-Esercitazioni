namespace Business_Logic.Models
{
    public class PacchettoVacanza
    {
        public int PacchettoID { get; set; }
        public string Codice { get; set; } = null!;
        public string? Nome { get; set; }
        public int Prezzo { get; set; }
        public int Durata { get; set; }
        public DateTime Data_Inizio { get; set; }
        public DateTime Data_Fine { get; set; }
        public int destinazioneRIF { get; set; }

    }
}
