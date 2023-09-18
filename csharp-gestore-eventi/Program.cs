using System.Runtime.CompilerServices;

namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Benvenuto alla pagina di gestione Eventi di Experis!");
                Console.WriteLine("Crea un EVENTO:");
                Console.WriteLine("Titolo:");
                string titolo = Console.ReadLine();
                Console.WriteLine("Data (Nel formato giusto yyyy-MM-dd HH:mm) :");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Capienza massima:");
                int capienzaMassima = int.Parse(Console.ReadLine());
                Console.WriteLine("Vuoi proseguire prenotando dei posti riservati per il tuo staff e parenti? Rispondi y/n :");
                string risposta1 = Console.ReadLine();
                Evento eventoEsempio1 = new Evento(titolo,  data, capienzaMassima);
                if (risposta1 == "y")
                {
                    Console.WriteLine("Numero dei posti riservati da prenotare?");
                    int postiPrenotati = int.Parse(Console.ReadLine());
                    eventoEsempio1.PrenotaPosti(capienzaMassima, postiPrenotati);
                }
                if (risposta1 == "n")
                {
                    Console.WriteLine("Ok, questo è un riepilogo dell'evento:");
                    Console.WriteLine($"Titolo: {titolo}");
                    Console.WriteLine($"La capienza massima è: {capienzaMassima} posti");
                    Console.WriteLine($"La programmazione prevista è per il: {data}");
                }
                Console.WriteLine("Vuoi proseguire disdicendo delle prenotazioni? Rispondi y/n :");
                string risposta2 = Console.ReadLine();
                if (risposta2 == "y")
                {
                    Console.WriteLine("Numero di prenotazioni da disdire?");
                    int postiDisdetti = int.Parse(Console.ReadLine());
                    eventoEsempio1.DisdiciPosti(postiDisdetti);

                }
                if (risposta2 == "n")
                {
                    Console.WriteLine("Ok, questo è un riepilogo dell'evento:");
                    Console.WriteLine($"Titolo: {titolo}");
                    Console.WriteLine($"La capienza massima è: {capienzaMassima} posti");
                    Console.WriteLine($"La programmazione prevista è per il: {capienzaMassima}");
                }
            } catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            } 
            // DA FINIRE DI COMPILARE
        }
    }
}