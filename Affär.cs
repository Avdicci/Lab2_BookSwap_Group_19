using System;

namespace Oosu_LAB1
{
    public class Affär
    {
        private int id;
        private DateTime datum;
        private string status;

        public Affär(int id)
        {
            this.id = id;
        }

        public void skapaAffär(Student student, Annons annons)
        {
            this.datum = DateTime.Now;
            this.status = "Reserverad";

            annons.uppdateraStatus("Reserverad");
        }

        // Inte det bästa sättet att uppdatera status, men det får duga för iteration 1
        public void uppdateraStatus(string nyStatus)
        {
            // Behöver felhantering
            this.status = nyStatus;
        }


        public int getId()
        {
            return id;
        }
    }
}


