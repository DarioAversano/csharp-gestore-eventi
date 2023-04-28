using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        //Attributi
        private string titolo;
        private DateTime data;
        private int capienzaMassima;
        private int numeroPostiPrenotati;



        // Getters

        public string GetTitolo()
        {
            return this.titolo;
        }
        public DateTime Data
        {
            get { return data; }
            set
            {
                if (value > DateTime.Today)
                    data = value;
                else
                    throw new Exception("Questa data è gia passata.");
            }
        }

        public int GetCapienzaMassima()
        {
            return this.capienzaMassima;
        }

        public float GetNumeroPostiPrenotati()
        {
            return this.numeroPostiPrenotati;
        }

        // Setter
        public void setBrand(string Titolo)
        {
            this.titolo = Titolo;
        }
        // Costruttore
        public Evento(string titolo, DateTime data, int capienzaMassima, int numeroPostiPrenotati=0)
        {
            if (titolo == "")
            {
                throw new Exception("Il titolo non può essere vuoto.");
            }
            
            if (capienzaMassima <= 0)
            {
                throw new Exception("Il numero della capienza posti non può essere inferiore a 1.");
            }
           
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassima = capienzaMassima;
            this.numeroPostiPrenotati = numeroPostiPrenotati;
        }

        // Metodi
        public void PrenotaPosti(int numeroPrenotazioniPosti)
        {
            if (numeroPrenotazioniPosti <= 0 || data.CompareTo(DateTime.Now) < 0)
            {
                throw new Exception("Inserire una data ed un numero di posti valido per la prenotazione");
            }
            this.numeroPostiPrenotati += numeroPrenotazioniPosti;
        }

        public void DisdiciPosti(int numeroPrenotazioniPosti)
        {
            if (numeroPrenotazioniPosti <= 0 || data.CompareTo(DateTime.Now) < 0)
            {
                throw new Exception("Inserire una data ed un numero di posti valido per la cancellazione");
            }
            this.numeroPostiPrenotati -= numeroPrenotazioniPosti;
        }

        public override string ToString()
        {
            string info = "--------- Evento: ----------\n";
            info += $"\t Titolo: {titolo}\n";
            info += $"\t Giorno: {data.ToString("dd/MM/yyyy")}\n";
            info += $"****************************";

            return info;
        }



    }






































}
