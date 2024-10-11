namespace REST_05_EF_Videoteche_Ref.Models
{
    public class SupportoDTO
    {
        public string codi { get; set; }
        public string tito { get; set; } = null!;
        public int anno { get; set; }
        public bool disp { get; set; }
        public string tipo { get; set; } = null!;
    }
}
