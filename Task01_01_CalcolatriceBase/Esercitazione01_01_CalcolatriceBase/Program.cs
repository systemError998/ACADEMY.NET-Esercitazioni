using System.Security.Cryptography.X509Certificates;

namespace Esercitazione01_01_CalcolatriceBase
{
    internal class Program
    {
        public void InputUtente()
        {

        }
        static void Main(string[] args)
        {
            bool cicloInfinito = true;
            while (cicloInfinito) {
                //NUMERO 1
                Console.WriteLine($"CHE OPERAZIONE VUOI EFFETTUARE? \n " +
                    $"+ per l'addizione , \n - per la sottrazione, \n * per la moltiplicazione, \n / per la divisione \n" +
                    $"'R' per la radice quadrata, \n'P' per la potenza, \n'Q' per uscire dal programma \n" +
                    $"[Per le operazioni con numeri decimali utilizzare la virgola e non il punto.]");
                string segno = Console.ReadLine().ToUpper();

                if (segno == "Q")
                {
                    cicloInfinito = false;
                }
                else {
                    Console.WriteLine("CON QUANTI NUMERI VUOI EFFETTUARE L'OPERAZIONE?");
                    int rispNum = 0;
                    try
                    {
                        rispNum = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Quello che hai inserito è tutto fuorchè un numero");
                    }
                    if (rispNum == 2)
                    {
                        //Le inizializzo all'esterno in maniera tale da poterle leggere ovunque
                        double a = 0;
                        double b = 0;

                        //PROVO A PRENDERE IN INPUT E CONVERTIRE IL PRIMO NUMERO
                        try
                        {
                            Console.Write("Inserisci un numero =>  ");
                            //prendo in input una stringa, ma per l'operazione necessito di un numero, quindi lo converto
                            a = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Inserisci un altro numero =>  ");
                            //prendo in input una stringa, ma per l'operazione necessito di un numero, quindi lo converto
                            b = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(" Eccezione: Numero non valido");
                        }

                        switch (segno)
                        {
                            case "+":
                                // double addizione = a + b; OTTIMIZZO?
                                Console.Write($"Il risultato di {a}+{b} è {a + b}");
                                break;
                            case "-":
                                // double sottrazione = a - b;
                                Console.WriteLine($"Il risultato di {a}-{b} è {a - b}");
                                break;
                            case "*":
                                // double moltiplicazione = a * b;
                                Console.WriteLine($"Il risultato di {a}*{b} è {a * b}");
                                break;
                            case "/":
                                if (b == 0)
                                {
                                    Console.WriteLine("Error");
                                }
                                else
                                {
                                    // double divisione = a / b;
                                    Console.WriteLine($"Il risultato di {a}/{b} è {a / b}");
                                }
                                break;
                            case "R":
                                if (b != 2)
                                    b = 2;

                                Console.WriteLine($"Il risultato della radice quadrata di {a} è {Math.Sqrt(a)}");
                                break;
                            case "P":
                                Console.WriteLine($"Il risultato di {a} elevato alla {b} è {Math.Pow(a, b)}");
                                break;
                            case "Q":
                                cicloInfinito = false;
                                break;
                            default:
                                Console.WriteLine("Quella che hai inserito non è un'operazione minchia scrivi");
                                break;
                        }
                    }
                    else {
                        List<double> operazioneTantiElementi = new List<double>();
                        double numeroPerArrayTantiElementi = 0;
                        double risultatoOperazioneTantiElementi = 0;
                        for (int i = 0; i < rispNum; i++) {
                            Console.WriteLine("sto nel for in cui aggiungo roba all'array");
                            if (i == 0) {
                                Console.WriteLine("Inserisci un numero");
                            }

                            Console.WriteLine("Inserisci un altro numero");
                            numeroPerArrayTantiElementi = Convert.ToInt32(Console.ReadLine());
                            operazioneTantiElementi.Add(numeroPerArrayTantiElementi);
                        }

                        switch (segno)
                        {
                            case "+":
                                foreach (double numero in operazioneTantiElementi) {
                                    risultatoOperazioneTantiElementi += numero;
                                    Console.WriteLine(risultatoOperazioneTantiElementi);
                                }
                                break;
                            case "-":
                                foreach (double numero in operazioneTantiElementi)
                                {
                                    risultatoOperazioneTantiElementi -= numero;
                                    Console.WriteLine(risultatoOperazioneTantiElementi);
                                }
                                break;
                            case "*":
                                foreach (double numero in operazioneTantiElementi)
                                {
                                    risultatoOperazioneTantiElementi *= numero;
                                    Console.WriteLine(risultatoOperazioneTantiElementi);
                                }
                                break;
                            case "/":
                                foreach (double numero in operazioneTantiElementi)
                                {
                                    if (numero == 0)
                                    {
                                        Console.WriteLine("Error");
                                    }
                                    else
                                    {
                                        risultatoOperazioneTantiElementi /= numero;
                                        Console.WriteLine(risultatoOperazioneTantiElementi);
                                        
                                    }
                                }
                                break;
                                case "R":
                                if (operazioneTantiElementi.Count > 2)
                                {
                                    operazioneTantiElementi.Capacity = 2;
                                    operazioneTantiElementi[1] = 2;
                                    risultatoOperazioneTantiElementi = Math.Sqrt(operazioneTantiElementi[0]);
                                }
                                else {
                                    Console.WriteLine("cazzo fai, mi bastano due numeri per fare la radice quadrata");
                                }
                                break;
                            case "Q":
                                cicloInfinito = false;
                                break;
                            default:
                                Console.WriteLine("Quella che hai inserito non è un'operazione minchia scrivi");
                                break;

                        }


                    

                    
                }

                
            }
        }

        

    }
}
