namespace Business_Logic.Models.DTO
{
    public class RecensioneDTO
    {
        public string codi { get; set; } = null!;
        public string uten { get; set; } = null!;
        public int voto { get; set; }
        public string? text { get; set; }
        public DateTime data { get; set; }
        public int pacchettoRIF { get; set; }
    }
}
