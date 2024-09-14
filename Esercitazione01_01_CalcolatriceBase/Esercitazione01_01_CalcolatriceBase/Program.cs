using System.Security.Cryptography.X509Certificates;

namespace Esercitazione01_01_CalcolatriceBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cicloInfinito = true;
            while (cicloInfinito) {
                //NUMERO 1
                Console.Write($"CHE OPERAZIONE VUOI EFFETTUARE? \n " +
                    $"+ per l'addizione , \n - per la sottrazione, \n * per la moltiplicazione, \n / per la divisione" +
                    $"'R' per la radice quadrata, \n 'P' per la potenza, \n 'Q' per uscire dal programma");
                string segno = Console.ReadLine().ToUpper();

                if (segno == "Q")
                {
                    cicloInfinito = false;
                }
                else {
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

                    ////PROVO A PRENDERE IN INPUT E CONVERTIRE IL SECONDO NUMERO
                    //try
                    //{
                    //    Console.Write("Inserisci un numero");
                    //    //prendo in input una stringa, ma per l'operazione necessito di un numero, quindi lo converto
                    //    b = Convert.ToDouble(Console.ReadLine());
                    //}
                    //catch (Exception)
                    //{
                    //    Console.WriteLine(" Eccezione: Numero non valido");
                    //}

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

                
            }
        }

    }
}
