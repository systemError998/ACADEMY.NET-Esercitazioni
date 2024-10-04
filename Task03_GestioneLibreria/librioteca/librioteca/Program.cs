using librioteca.Models;
using System.Security.Cryptography;

namespace librioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool insAbi = true;
            while (insAbi)
            {
                Console.WriteLine("Digita il comando per scegliere l'operazioe\n" +
                    "I - Inserimento\n" +
                    "S - Stampa\n" +
                    "A - Aggiorna\n" +
                    "C - Cancella\n" +
                    "Q - Esci");

                string? inputUtente = Console.ReadLine();

                switch (inputUtente)
                {
                    case "I":          
                        Console.WriteLine("Cosa vuoi inserire?\n" +
                                    "U - Utente\n" +
                                    "L - Libro\n" +
                                    "P - Prestito\n" +
                                    "Q - Indietro");
                        string? inputUtente2 = Console.ReadLine();
                        switch (inputUtente2)
                        {
                            case "U":   // AGGIUNGI UTENTE

                                Console.WriteLine("Inserisci il nome dell'utente");
                                string? inNome = Console.ReadLine();
                                Console.WriteLine("Inserisci il cognome dell'utente");
                                string? inCognome = Console.ReadLine();
                                Console.WriteLine("Inserisci l'email dell'utente");
                                string? inEmail = Console.ReadLine();

                                if (inNome != "" && inCognome != "" && inEmail != "")
                                {
                                    using (var ctx = new Task03BibliotecaContext())
                                    {
                                        try
                                        {
                                            Utente user = new Utente()
                                            {
                                                Nome = inNome is not null ? inNome : "N.D.",
                                                Cognome = inCognome is not null ? inCognome : "N.D.",
                                                Email = inEmail is not null ? inEmail : "N.D."
                                            };
                                            ctx.Utentes.Add(user);
                                            ctx.SaveChanges();
                                            Console.WriteLine("Utente Aggiunto con successo!");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Qualcosa è andato storto nella creazione dell'utente!");
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Controlla i campi");
                                }
                                break;
                            case "L":   // AGGIUNGI LIBRO

                                Console.WriteLine("Inserisci il titolo del libro");
                                string? inTitolo = Console.ReadLine();
                                Console.WriteLine("Inserisci il nome dell'autore");
                                string? inAutore = Console.ReadLine();
                                Console.WriteLine("Inserisci l'anno di uscita");
                                string inAnno = Console.ReadLine();
                                int inAnno1;

                                if (inTitolo != "" && inAutore != "" && Int32.TryParse(inAnno, out inAnno1) != false)
                                {
                                    using (var ctx = new Task03BibliotecaContext())
                                    {
                                        try
                                        {
                                            Libro libro = new Libro()
                                            {
                                                Titolo = inTitolo is not null ? inTitolo : "N.D.",
                                                Autore = inAutore is not null ? inAutore : "N.D.",
                                                Anno = inAnno1
                                            };
                                            ctx.Libros.Add(libro);
                                            ctx.SaveChanges();
                                            Console.WriteLine("Libro Aggiunto con successo!");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Qualcosa è andato storto nella creazione del libro!");
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Controlla i campi");
                                }
                                break;
                            case "P":   // AGGIUNGI PRESTITO

                                Console.WriteLine("Inserisci ID Utente");
                                string inIdUtente = Console.ReadLine();
                                Console.WriteLine("Inserisci ID Libro");
                                string? inIDLibro = Console.ReadLine();

                                int inIdUtente1;
                                int inIDLibro1;

                                if (Int32.TryParse(inIdUtente, out inIdUtente1) != false && Int32.TryParse(inIDLibro, out inIDLibro1) != false)
                                {
                                    using (var ctx = new Task03BibliotecaContext())
                                    {
                                        try
                                        {
                                            Console.WriteLine(ctx.Utentes.FirstOrDefault(u => u.Nome == inIdUtente));
                                            Prestito prestito = new Prestito()
                                            {
                                                LibroRif = inIDLibro1
                                            };



                                            ctx.Prestitos.Add(prestito);

                                            ctx.SaveChanges();

                                            Console.WriteLine("Prestito Aggiunto con successo!");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Qualcosa è andato storto nella creazione del prestito!");
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Controlla i campi");
                                }

                                break;
                            default:
                                Console.WriteLine("Non conosco questo comando!");
                                break;
                        }



                        break;
                    case "S":
                        Console.WriteLine("Cosa vuoi vedere?\n" +
                                    "U - Utenti\n" +
                                    "L - Libri\n" +
                                    "P - Prestiti\n" +
                                    "T - Tutto\n" +
                                    "Q - Indietro");
                        string? inputUtente3 = Console.ReadLine();
                        switch (inputUtente3)
                        {
                            case "U":   // VISUALIZZA UTENTI

                                //List<Giocattolo> elenco = GiocattoloDAO.GetInstance().GetAll();
                                //Console.WriteLine("Entrato in stampa");
                                //foreach (Giocattolo gioc in elenco)
                                //{
                                //    Console.WriteLine(gioc.Nome);  //elenco.AddRange()
                                //}

                                break;
                            case "L":   // VISUALIZZA LIBRI
                                break;
                            case "P":   // VISUALIZZA PRESTITI
                                break;
                            default:
                                Console.WriteLine("Non conosco questo comando!");
                                break;
                        }

                        break;
                    case "A":
                        //----------------------AGGIORNA----------------------------------//

                        Console.WriteLine("Cosa vuoi aggiornare?\n" +
                                    "U - Utente\n" +
                                    "L - Libro\n" +
                                    "P - Prestito\n" +
                                    "Q - Indietro");
                        string? inputUtente4 = Console.ReadLine();
                        switch (inputUtente4)
                        {
                            case "U":   // MODIFICA DATI UTENTI

                                //List<Giocattolo> elenco = GiocattoloDAO.GetInstance().GetAll();
                                //Console.WriteLine("Entrato in stampa");
                                //foreach (Giocattolo gioc in elenco)
                                //{
                                //    Console.WriteLine(gioc.Nome);  //elenco.AddRange()
                                //}

                                break;
                            case "L":   // MODIFICA DATI LIBRI
                                break;
                            case "P":   // MODIFICA DATA RESTITUZIONE PRESTITI  --> modifica status libro a disponibile
                                break;
                            default:
                                Console.WriteLine("Non conosco questo comando!");
                                break;
                        }

                        break;
                    case "C":
                        //----------------------CANCELLA----------------------------------//

                        Console.WriteLine("Cosa vuoi cancellare?\n" +
                                    "U - Utente\n" +
                                    "L - Libro\n" +
                                    "P - Prestito\n" +
                                    "Q - Indietro");
                        string? inputUtente5 = Console.ReadLine();
                        switch (inputUtente5)
                        {
                            case "U":   // CANCELLA UTENTE

                                //List<Giocattolo> elenco = GiocattoloDAO.GetInstance().GetAll();
                                //Console.WriteLine("Entrato in stampa");
                                //foreach (Giocattolo gioc in elenco)
                                //{
                                //    Console.WriteLine(gioc.Nome);  //elenco.AddRange()
                                //}

                                break;
                            case "L":   // CANCELLA LIBRO
                                break;
                            case "P":   // CANCELLA PRESTITO
                                break;
                            default:
                                Console.WriteLine("Non conosco questo comando!");
                                break;
                        }

                        break;

                    case "Q":
                        insAbi = false;
                        break;

                    default:
                        Console.WriteLine("Non conosco questo comando!");
                        break;
                }
            }
        }
    }
}
