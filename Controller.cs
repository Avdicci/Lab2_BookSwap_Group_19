using System;
//gfsdgsdgsegseg
namespace Oosu_LAB1
{
    public class Controller
    {
        private List<Annons> annonser = new List<Annons>();
        private List<Affär> affärer = new List<Affär>();
        private List<Student> studenter = new List<Student>();
        private List<Kurs> kurser = new List<Kurs>();

        public Controller()
        {
            // 1. Skapa studenter
            studenter.Add(new Student(1, "Kalle"));
            studenter.Add(new Student(2, "Lisa"));

            // 2. Skapa en kurs (Nytt för iteration 2!)
            Kurs oosu = new Kurs("C1OB1B", "Objektorienterad Systemutveckling 1");
            kurser.Add(oosu);

            // 3. Skapa en KursBok (eftersom Annons numera är abstrakt) och koppla till kursen
            KursBok minBok = new KursBok(10, "C# Boken", 200m, "Bra", "Till salu", oosu, "123-456", "Författare X", "Upplaga 1");
            annonser.Add(minBok);
        }

        public void HanteraReservation()
        {
            Annons valdAnnons = annonser[0];

            if (valdAnnons.kontrolleraTillgänglig())
            {
                Affär nyAffär = new Affär(1);
                nyAffär.skapaAffär(studenter[0], valdAnnons);
                affärer.Add(nyAffär);

                Console.WriteLine("Klart! Annonsen är reserverad.");
            }
            else
            {
                Console.WriteLine("Annonsen är redan jippad bror");
            }
        }
    }
}
