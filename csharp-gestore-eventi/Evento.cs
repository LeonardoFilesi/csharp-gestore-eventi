using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        // PROPRIETA'
        public string Titolo { get; set; }
        public DateTime Data { get; set; }
        public int CapienzaMassima { get; }
        public int PostiPrenotati { get; }

        //GETTERS
        public string MostraTitolo()
        {
            return this.Titolo;
        }
        public DateTime MostraData()
        {
            return this.Data;
        }
        public int MostraCapienza()
        {
            return this.CapienzaMassima;
        }
        public int MostraPosti()
        {
            return this.PostiPrenotati;
        }

        //SETTERS
        public void SetTitolo(string titolo)
        {
            if (string.IsNullOrWhiteSpace(titolo)) 
            {
                throw new ArgumentException();
            }
        }
        public void SetData(DateTime data)
        {
            if (data > DateTime.Now)
            {
                throw new ArgumentException("La data inserita è ERRATA, non può essere nel futuro");
            }
        }
        public void SetCapienza(int capienzaMassima)
        {
            if (capienzaMassima <= 0)
            {
                throw new ArgumentException("La capienza massima deve essere un numero intero positivo");
            }
        }

        // COSTRUTTORE
        public Evento(string titolo, DateTime data, int capienzaMassima, int postiPrenotati)
        {
            this.Titolo = titolo;
            this.Data = data;
            this.CapienzaMassima = capienzaMassima;
            this.PostiPrenotati = postiPrenotati;
        }

        // METODI 
        public void PrenotaPosti(int capienzaMassima, int postiPrenotati, int prenotazione)
        {   
            if ((capienzaMassima - postiPrenotati) > prenotazione )
            {
                Console.WriteLine($"Congratulazioni, ha prenotato con successo {prenotazione} posti");
                Console.WriteLine($"I posti totali prenotati ora sono {(postiPrenotati + prenotazione)}");
            }
            else { throw new Exception($"Mi spiace, hai prenotato troppi posti, quelli disponibili sono solo {(capienzaMassima - postiPrenotati)}"); }
        }
    }

}
