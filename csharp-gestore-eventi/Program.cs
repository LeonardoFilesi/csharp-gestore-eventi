namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto alla pagina di gestione Eventi di Experis!");
            Console.WriteLine("Crea un EVENTO:");
            Console.WriteLine("Titolo:");
            string titolo = Console.ReadLine();
            Console.WriteLine("Data (Nel formato giusto yyyy-MM-dd HH:mm) :");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Capienza massima:");
            int capienzaMassima = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuoi proseguire prenotando dei posti riservati per il tuo staff e parenti? rispondi Y/N ");
            string risposta = Console.ReadLine();
            if 
        }
    }
}