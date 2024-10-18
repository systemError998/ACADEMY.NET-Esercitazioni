namespace Business_Logic.Models
{
    public class Recensione
    {
        public int RecensioneID { get; set; }
        public string Codice { get; set; } = null!;
        public string NomeUtente { get; set; } = null!;
        public int Voto { get; set; }
        public string? Commento { get; set; }
        public DateTime DataRecensione { get; set; }
        public int PacchettoRIF { get; set; }

    }
}
