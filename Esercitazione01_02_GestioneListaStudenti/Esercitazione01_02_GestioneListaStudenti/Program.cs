using Esercitazione01_02_GestioneListaStudenti.classes;

namespace Esercitazione01_02_GestioneListaStudenti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //bool on = true;
            //while (on) {
            //    Console.WriteLine("---BENVENUTO NELLA GESTIONE DELLA LISTA STUDENTI---");
            //    Console.WriteLine("-----------------COSA VUOI FARE?-------------------");
            //    Console.WriteLine("S PER STAMPARE LA LISTA STUDENTI \n " +
            //        "A PER CREARE UNO STUDENTE" +
            //        "M PER MODIFICARE UNO STUDENTE" +
            //        "D PER CANCELLARE UNO STUDENTE");


            //    on = false;
            //}


            
            Universita iemme = new Universita();

            Studente giu = new Studente("Giulio","Cerasoli",9.5);
            Studente roby = new Studente("Roberta","Balzotti",6.6);
            Studente anna = new Studente("Anna","Panna",1);

            iemme.AggiungiStudente(giu);
            iemme.AggiungiStudente(roby);
            iemme.AggiungiStudente(anna);

            anna.ModificaStudente("Anna", "Cerasoli", 1);

            // iemme.FiltraStudenti(1);

        }
    }
}
