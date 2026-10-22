using System;
using System.Collections.Generic;

<<<<<<< HEAD
using System;

=======
>>>>>>> 2f8796b (Initial commit)
namespace Oosu_LAB1
{
    class Program
    {
        static void Main()
        {
<<<<<<< HEAD
            // Skapar controllern som håller i all data och logik
            Controller controller = new Controller();
            bool kör = true;

=======
            List<Annons> annonser = new List<Annons>();
            List<Affär> affärer = new List<Affär>();
            List<Student> studenter = new List<Student>();

            // 1. Ett par studenter i en List<T>
            studenter.Add(new Student(1, "Kalle"));
            studenter.Add(new Student(2, "Lisa"));

            // Instansierar Annons och addar in i lista "minAnnons"
            Annons minAnnons = new Annons(10, "C# Boken", 200m, "Bra", "Till salu");
            annonser.Add(minAnnons);

            bool kör = true;

            // 2. Loop
>>>>>>> 2f8796b (Initial commit)
            while (kör)
            {
                Console.WriteLine("\n1. Reservera annons 10\n0. Avsluta");
                Console.Write("Välj: ");
                string val = Console.ReadLine();

<<<<<<< HEAD
=======
                // 3. int.TryParse
>>>>>>> 2f8796b (Initial commit)
                if (int.TryParse(val, out int menyVal))
                {
                    switch (menyVal)
                    {
                        case 1:
<<<<<<< HEAD
                            Console.WriteLine("Valt alternativ: 1 (Reservera annons)\n");
                            // Program ber controllern göra jobbet
                            controller.HanteraReservation();
                            break;
=======
                            // 4. Skriver ut strängrepresentation av menyvalet
                            Console.WriteLine("Valt alternativ: 1 (Reservera annons)");

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
                                break;
>>>>>>> 2f8796b (Initial commit)

                        case 0:
                            Console.WriteLine("Valt alternativ: 0 (Avsluta)");
                            kör = false;
                            break;
<<<<<<< HEAD

                        default:
                            Console.WriteLine("Ogiltigt val.");
                            break;
=======
>>>>>>> 2f8796b (Initial commit)
                    }
                }
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 2f8796b (Initial commit)
