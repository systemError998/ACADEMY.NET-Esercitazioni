using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione01_02_GestioneListaStudenti.classes
{
    internal class Studente 
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public int Voto { get; set; }
        public List<Studente> ListaStudenti { get; set; } = new List<Studente>();

        public Studente(string varNome, string varCognome, int varVoto) {
            Nome = varNome;
            Cognome = varCognome;
            Voto = varVoto;
        }
        public void AggiungiStudente(Studente objStudente) {
            ListaStudenti.Add(objStudente);
        }

        public void RimuoviStudente(Studente objStudente)
        {
            
        }

        public void ModificaStudente(string varNome, string varCognome, int varVoto) {
            Nome = varNome;
            Cognome = varCognome;
            Voto = varVoto;
        }

        public override string ToString() {
            return $"[STUDENTE] {Nome} {Cognome} VOTO: {Voto}";
        }

        public void StampaStudenti() {
            foreach (Studente stu in ListaStudenti)
            {
                Console.WriteLine(stu.ToString());
            }
        }

        public void FiltraStudenti()
        {
            
        }
    }
}
