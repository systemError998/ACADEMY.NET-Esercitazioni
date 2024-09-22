using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione01_02_GestioneListaStudenti.classes
{
    internal class Universita
    {
        public string? Nome { get; set; }
        public string? Indirizzo { get; set; }
        public string? Facolta { get; set; }
        public List<Studente> ListaStudenti { get; set; } = new List<Studente>();    //AGGREGAZIONE

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
            else
            {
                Console.WriteLine("Non esiste questo studente, che te voi eliminà?");
            }
        }

        public void StampaStudenti()
        {
            if (ListaStudenti is not null)
            {
                foreach (Studente stu in ListaStudenti)
                {
                    Console.WriteLine(stu.ToString());
                }
            }
            else
            {
                Console.WriteLine("non c'è nessuno studentazzo qua");
            }
        }

        //public void FiltraStudenti(double varVoto)
        //{
        //    foreach (Studente stu in ListaStudenti)
        //    {
        //        if (varVoto == 1)
        //        {
        //            Console.WriteLine(stu);
        //        }
        //        else if (stu.Voto == 2) { 
                    
        //        }
                
        //    }
        //}

    }
}
