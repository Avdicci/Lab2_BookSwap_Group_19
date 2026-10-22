using System;
using System.Collections.Generic;

using System;

namespace Oosu_LAB1
{
    class Program
    {
        static void Main()
        {
            // Skapar controllern som håller i all data och logik
            Controller controller = new Controller();
            bool kör = true;

            while (kör)
            {
                Console.WriteLine("\n1. Reservera annons 10\n0. Avsluta");
                Console.Write("Välj: ");
                string val = Console.ReadLine();

                if (int.TryParse(val, out int menyVal))
                {
                    switch (menyVal)
                    {
                        case 1:
                            Console.WriteLine("Valt alternativ: 1 (Reservera annons)\n");
                            // Program ber controllern göra jobbet
                            controller.HanteraReservation();
                            break;

                        case 0:
                            Console.WriteLine("Valt alternativ: 0 (Avsluta)");
                            kör = false;
                            break;

                        default:
                            Console.WriteLine("Ogiltigt val.");
                            break;
                    }
                }
            }
        }
    }
}
