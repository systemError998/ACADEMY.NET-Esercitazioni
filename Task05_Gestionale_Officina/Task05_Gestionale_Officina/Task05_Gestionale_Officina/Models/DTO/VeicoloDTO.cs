namespace Task05_Gestionale_Officina.Models.DTO
{
    public class VeicoloDTO
    {
        public string CodVeicolo { get; set; } = null!;
        public string Targa { get; set; } = null!;
        public string Modello { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public int Anno { get; set; }
        public decimal PrezzoIntervento { get; set; }
        public string StatoIntervento { get; set; } = null!;
        public DateTime DataIngresso { get; set; }
    }
}
