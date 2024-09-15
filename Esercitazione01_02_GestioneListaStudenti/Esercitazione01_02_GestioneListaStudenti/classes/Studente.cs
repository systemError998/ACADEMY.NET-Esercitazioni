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


        public Studente(string varNome, string varCognome, double varVoto) {
            Nome = varNome;
            Cognome = varCognome;
            Voto = varVoto;
        }
        
        public void ModificaStudente(string varNome, string varCognome, double varVoto) {
            Nome = varNome;
            Cognome = varCognome;
            Voto = varVoto;
        }

        public override string ToString() {
            return $"[STUDENTE] {Nome} {Cognome} VOTO: {Voto}";
        }

        

        
    }
}
