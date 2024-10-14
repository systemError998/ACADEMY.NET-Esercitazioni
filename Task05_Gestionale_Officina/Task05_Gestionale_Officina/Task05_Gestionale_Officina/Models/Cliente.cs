using System.ComponentModel.DataAnnotations.Schema;

namespace Task05_Gestionale_Officina.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public int ClienteID { get; set; } //la proprerty nasconde la definizione implicita dell'attributo
        public string CodCliente { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string Indirizzo { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public List<Veicolo> Veicoli { get; set; } = new List<Veicolo>();
    }
}
