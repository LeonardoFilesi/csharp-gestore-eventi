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
        // 1)-------------------------------------------------------------------------------------------------------------------------------------------
        private string _titolo;
        public string Titolo 
        {
            get
            {
                return this._titolo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))   // Value: valore scritto dall'utente
                {
                    throw new Exception("Deve esserci un titolo");
                }
                this._titolo = value;
            }
        }
        // 2)-------------------------------------------------------------------------------------------------------------------------------------------
        private DateTime _data;
        public DateTime Data 
        { 
            get
            {
                return this._data;
            }
            set
            {

            if (value > DateTime.Now)                  // Value: valore scritto dall'utente
                {
                throw new Exception("La data inserita è ERRATA, non può essere nel futuro");
            }
            this.Data = value;
            }
        }
        // 3)---------------------------------------------------------------------------------------------------------------------------------------------
        public int CapienzaMassima { get; }
        // 4)---------------------------------------------------------------------------------------------------------------------------------------------
        public int PostiPrenotati { get; private set; }


        // SETTERS
      
        public void SetData(DateTime data)
        {
        }
        public void SetCapienza(int capienzaMassima)
        {
            if (capienzaMassima <= 0)
            {
                throw new Exception("La capienza massima deve essere un numero intero positivo");
            }
        }

        // COSTRUTTORE
        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            this.Titolo = titolo;
            this.Data = data;
            this.CapienzaMassima = capienzaMassima;
        }

        // METODI 
        public void PrenotaPosti(int capienzaMassima, int postiPrenotati)
        {
            
            if (capienzaMassima > postiPrenotati )
            {
                this.PostiPrenotati = postiPrenotati;
                Console.WriteLine($"Congratulazioni, ha prenotato con successo {postiPrenotati} posti");
                Console.WriteLine($"Ora i posti disponibili sono {(capienzaMassima - postiPrenotati)}");
                
            }
            if (postiPrenotati > capienzaMassima)
            { 
                throw new Exception($"Mi spiace, hai prenotato troppi posti, la capienza massima è di {capienzaMassima} posti"); 
            }
            
        }
        public void DisdiciPosti(int capienzaMassima, int postiPrenotati, int postiDisdetti, string titolo, DateTime data)
        {   
            if (postiPrenotati < postiDisdetti)
            {
                throw new Exception($"NON PUOI disdire più prenotazioni ({postiDisdetti}) di quelle che hai fatto ({postiPrenotati})");
            }
            if (postiPrenotati == postiDisdetti)
            {
                Console.WriteLine("Hai cancellato tutte le tue prenotazioni");
            }
            if (postiPrenotati > postiDisdetti)
            {
                Console.WriteLine($"Bene, hai prenotato {postiPrenotati - postiDisdetti}, sono rimasti disponibili {capienzaMassima - postiPrenotati} per l'evento {titolo} del {data}");
            }
        }
        
    }

}
