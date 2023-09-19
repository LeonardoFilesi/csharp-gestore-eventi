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
        // PROPRIETA'===================================================================================================================================
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
                    throw new ArgumentException("Deve esserci un titolo");
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
            this._data = value;
            }
        }
       
        // 3)---------------------------------------------------------------------------------------------------------------------------------------------
        public int CapienzaMassima { get; }
        // 4)---------------------------------------------------------------------------------------------------------------------------------------------
        public int PostiPrenotati { get; private set; }

        // SETTERS========================================================================================================================================
        public void SetCapienza(int capienzaMassima)
        {
            if (capienzaMassima <= 0)
            {
                throw new Exception("La capienza massima deve essere un numero intero positivo");
            }
        }

        // COSTRUTTORE===================================================================================================================================
        public Evento(string titolo, DateTime data, int capienzaMassima)
        {
            this.Titolo = titolo;
            this.Data = data;
            this.CapienzaMassima = capienzaMassima;
        }

        // METODI=======================================================================================================================================
        // 1)-------------------------------------------------------------------------------------------------------------------------------------------
        public void PrenotaPosti(int capienzaMassima, int postiPrenotati)
        {
            
            if (capienzaMassima > (PostiPrenotati + postiPrenotati))
            {
                this.PostiPrenotati += postiPrenotati;
                Console.WriteLine($"Congratulazioni, ha prenotato con successo {postiPrenotati} posti");
                Console.WriteLine($"Ora i posti disponibili sono {(capienzaMassima - this.PostiPrenotati)}");
                
            }
            if (postiPrenotati > capienzaMassima)
            { 
                throw new Exception($"Mi spiace, hai prenotato troppi posti, la capienza massima è di {capienzaMassima} posti"); 
            }
            
        }
        // 2)-----------------------------------------------------------------------------------------------------------------------------------------
        public void DisdiciPosti( int postiDisdetti)
        {
            if (postiDisdetti < 0)
            {
                throw new Exception("Il numero di posti disdetti non può essere negativo");
            }
            else if (PostiPrenotati < postiDisdetti)
            {
                throw new Exception($"NON PUOI disdire più prenotazioni ({postiDisdetti}) di quelle che hai fatto ({PostiPrenotati})");
            }
            else if (PostiPrenotati == postiDisdetti)
            {
                Console.WriteLine("Hai cancellato tutte le tue prenotazioni");
            }
            else
            {   
                PostiPrenotati -= postiDisdetti;
                Console.WriteLine($"Bene, sono rimasti prenotati {PostiPrenotati}");
                Console.WriteLine($"Ora i posti disponibili sono {(CapienzaMassima - PostiPrenotati)}");
            }
        }
    }
}
