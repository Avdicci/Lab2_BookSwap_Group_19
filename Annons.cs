using System;

namespace Oosu_LAB1
{
    public abstract class Annons
    {
        private int id;
        private string titel;
        private decimal pris;
        private string beskrivning;
        private string status;
        private Kurs kurs; // NYTT: Associationen till Kurs

        public Annons(int id, string titel, decimal pris, string beskrivning, string status, Kurs kurs)
        {
            this.id = id;
            this.titel = titel;
            this.pris = pris;
            this.beskrivning = beskrivning;
            this.status = status;
            this.kurs = kurs; // Spara kursen
        }

        // Polymorfismen: Löftet om att alla annonser har GetInfo()
        public abstract string GetInfo();

        public bool kontrolleraTillgänglig()
        {
            return status == "Till salu";
        }

        public void uppdateraStatus(string nyStatus)
        {
            this.status = nyStatus;
        }

        public int getId()
        {
            return id;
        }
    }
}
