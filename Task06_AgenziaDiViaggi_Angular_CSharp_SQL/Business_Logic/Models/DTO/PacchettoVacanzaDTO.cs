namespace Business_Logic.Models.DTO
{
    public class PacchettoVacanzaDTO
    {
        public string cod { get; set; } = null!;
        public string? nom { get; set; }
        public int pri { get; set; }
        public int dur { get; set; }
        public DateTime ini { get; set; }
        public DateTime fin { get; set; }
        public int desRif { get; set; }
    }
}
