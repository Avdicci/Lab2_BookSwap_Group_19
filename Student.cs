using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 2f8796b (Initial commit)

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
<<<<<<< HEAD

        // Enligt diagram, dessa är out of scope och finns hör bara för att passa in med DCD
=======
        // Enligt diagram, dessa är out of scope och finns här bara för att passa in med DCD
>>>>>>> 2f8796b (Initial commit)
        public bool loggaIn() { return true; }
        public void loggaUt() { }
        public void reserveraAnnons(int annonsId) { }
        public void avbokaReservation(int annonsId) { }
    }
}
