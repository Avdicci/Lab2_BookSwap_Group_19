using System;
<<<<<<< HEAD

namespace Oosu_LAB1
{
    public abstract class Annons
    {
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oosu_LAB1
{
    public class Annons
    {
        //Attribut
>>>>>>> 2f8796b (Initial commit)
        private int id;
        private string titel;
        private decimal pris;
        private string beskrivning;
        private string status;
<<<<<<< HEAD
        private Kurs kurs; // NYTT: Associationen till Kurs

        public Annons(int id, string titel, decimal pris, string beskrivning, string status, Kurs kurs)
=======

        //Konstruktor
        public Annons(int id, string titel, decimal pris, string beskrivning, string status)
>>>>>>> 2f8796b (Initial commit)
        {
            this.id = id;
            this.titel = titel;
            this.pris = pris;
            this.beskrivning = beskrivning;
            this.status = status;
<<<<<<< HEAD
            this.kurs = kurs; // Spara kursen
        }

        // Polymorfismen: Löftet om att alla annonser har GetInfo()
        public abstract string GetInfo();

=======
        }

        // Om this.status == "Till salu" -> returna true
>>>>>>> 2f8796b (Initial commit)
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
