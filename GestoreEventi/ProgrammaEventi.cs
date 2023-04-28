using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        // Attributi
        private string titolo;
        private List<Evento> eventi;

        // Proprietà
        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public List<Evento> Eventi
        {
            get { return eventi; }
            set { eventi = value; }
        }

        // Costruttore
        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();
        }

        // Metodi
        public void AddEvento(Evento newEvento)
        {
            eventi.Add(newEvento);
        }

        // Metodo per restituire una lista di eventi in una certa data
        public List<Evento> EventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();

            foreach (Evento evento in eventi)
            {
                if (evento.Data == data)
                {
                    eventiInData.Add(evento);
                }
            }

            return eventiInData;
        }

        public int NumeroEventi()
        {
            return eventi.Count;
        }

        public void SvuotaEventi()
        {
            eventi.Clear();
        }

        public override string ToString()
        {
            string output = "Nome programma evento: " + titolo + "\n";

            foreach (Evento evento in eventi)
            {
                output += evento.Data.ToString("data") + " - " + evento.GetTitolo + "\n";
            }

            return output;
        }

    }

}