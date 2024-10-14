using System.ComponentModel.DataAnnotations.Schema;
using Task05_Gestionale_Officina.Models.DTO;

namespace Task05_Gestionale_Officina.Models
{
    [Table("Veicolo")]
    public class Veicolo
    {
        public int VeicoloID { get; set; } //la proprerty nasconde la definizione implicita dell'attributo
        public string CodVeicolo { get; set; } = null!;
        public string Targa { get; set; } = null!;
        public string Modello { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public int Anno { get; set; } 
        public decimal PrezzoIntervento { get; set; } 
        public string StatoIntervento { get; set; } = null!;
        public DateTime  DataIngresso { get; set; } 
        public int ClienteRIF { get; set; }
        public Cliente? ClienteNavigation { get; set; }
        public ClienteDTO? ClienteDTO { get; set; }
    }
}
