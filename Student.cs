using System;

namespace Oosu_LAB1
{
    public class Student
    {
        private int studentId;
        private string namn;

        //Konstruktor
        public Student(int studentId, string namn)
        {
            this.studentId = studentId;
            this.namn = namn;
        }

        // Enligt diagram, dessa är out of scope och finns hör bara för att passa in med DCD
        public bool loggaIn() { return true; }
        public void loggaUt() { }
        public void reserveraAnnons(int annonsId) { }
        public void avbokaReservation(int annonsId) { }
    }
}
