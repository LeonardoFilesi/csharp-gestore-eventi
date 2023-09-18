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
        // COSTRUTTORE
        public Evento(string titolo, DateTime data, int capienzaMassima, int postiPrenotati)
        {
            this.Titolo = titolo;
            this.Data = data;
            this.CapienzaMassima = capienzaMassima;
            this.PostiPrenotati = postiPrenotati;
        }

        //GETTER 
        public string MostraTitolo()
        {
            return this.Titolo;
        }

        public DateTime MostraData(DateTime data)
        {
            return this.Data;
        }

        public int MostraCapienza(int capienzaMassima)
        {
            return this.CapienzaMassima;
        }

        public int MostraPosti(int postiPrenotati)
        {
            return this.PostiPrenotati;
        }
    }

}
