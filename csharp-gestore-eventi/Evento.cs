using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
                throw new Exception("Deve esserci un titolo");
            }
            this.Titolo = titolo;
        }
        public void SetData(DateTime data)
        {
            if (data > DateTime.Now)
            {
                throw new Exception("La data inserita è ERRATA, non può essere nel futuro");
            }
            this.Data = data;
        }
        public void SetCapienza(int capienzaMassima)
        {
            if (capienzaMassima <= 0)
            {
                throw new Exception("La capienza massima deve essere un numero intero positivo");
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
        public void PrenotaPosti(int capienzaMassima, int postiPrenotati)
        {   
            if (capienzaMassima > postiPrenotati )
            {
                Console.WriteLine($"Congratulazioni, ha prenotato con successo {postiPrenotati} posti");
                Console.WriteLine($"Ora i posti disponibili sono {(capienzaMassima - postiPrenotati)}")
                
            }
            else { throw new Exception($"Mi spiace, hai prenotato troppi posti, la capienza massima è di {capienzaMassima} posti"); }
        }
        public void DisdiciPosti(int postiPrenotati)
        {

        }
        
    }

}
