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
        public double Voto { get; set; }
        public List<Studente> ListaStudenti { get; set; } = null;


        public Studente() { }
        public Studente(string varNome, string varCognome, double varVoto) {
            Nome = varNome;
            Cognome = varCognome;
            Voto = varVoto;
            if (ListaStudenti == null)
            {
                ListaStudenti = new List<Studente>();
            }

            ListaStudenti.Add(this);
        }
        public void AggiungiStudente(Studente objStudente)
        {
            if (ListaStudenti == null)
            {
                ListaStudenti = new List<Studente>();
            }

            ListaStudenti.Add(objStudente);
        }

        public void RimuoviStudente(Studente objStudente)
        {
            if (ListaStudenti.Contains(objStudente))
            {
                ListaStudenti.Remove(objStudente);
            }
            else {
                Console.WriteLine("Non esiste questo studente, che te voi eliminà?");
            }
        }

        public void ModificaStudente(string varNome, string varCognome, double varVoto) {
            Nome = varNome;
            Cognome = varCognome;
            Voto = varVoto;
        }

        public override string ToString() {
            return $"[STUDENTE] {Nome} {Cognome} VOTO: {Voto}";
        }

        public void StampaStudenti() {
            if (ListaStudenti is not null)
            {
                foreach (Studente stu in ListaStudenti)
                {
                    Console.WriteLine(stu.ToString());
                }
            }
            else {
                Console.WriteLine("non c'è nessuno studentazzo qua"); 
            }
        }

        public void FiltraStudenti()
        {
            
        }
    }
}
