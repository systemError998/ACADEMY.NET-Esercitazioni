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


            //Studente Elenco = new Studente(List<Studente>arrayListaStudenti);
            Studente stu = new Studente();
            Studente giu = new Studente("Giulio","Cerasoli",9.5);
            Studente roby = new Studente("Roberta","Balzotti",6.6);
            Studente anna = new Studente("Anna","Panna",1);


            Console.WriteLine("primi studenti aggiungti");
            stu.StampaStudenti();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("rimuovo giu");
            stu.RimuoviStudente(giu);
            stu.StampaStudenti();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("modifico roby");
            roby.ModificaStudente("Roberta Silvia", "Balzotti", 8);
            Console.WriteLine("stampo gli studenti modificati");
            stu.StampaStudenti();

        }
    }
}
