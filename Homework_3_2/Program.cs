using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lowerLimit = 0;
            var upperLimit = 100;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Spróbuj odgadnąć wylosowaną liczbę, która jest z przedziału [{lowerLimit};{upperLimit}].");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Losujemy liczbę...");
            var rnd = new Random();
            var drawnNumber = rnd.Next(lowerLimit, upperLimit);

            Console.WriteLine(drawnNumber);

            var i = 0;
            while (true)
            {
                Console.Write("Podaj liczbę: ");

                var yourNumber = GetNumber(lowerLimit, upperLimit);

                i++;

                if (yourNumber < drawnNumber)
                {
                    Console.WriteLine("Podana liczba jest za mała.");
                    continue;
                }
                if (yourNumber > drawnNumber)
                {
                    Console.WriteLine("Podana liczba jest za duża.");
                    continue;
                }

                Console.WriteLine($"Brawo! Udało Ci się trafić w {i} próbach.");
                break;
            }
        }

        private static int GetNumber(int lowerLimit, int upperLimit)
        {
            while (true)
            {

                if (!int.TryParse(Console.ReadLine(), out int number) || number < lowerLimit || number > upperLimit)
                {
                    Console.WriteLine("Wpisałeś nieprawidłowe dane, spróbuj ponownie.");
                    continue;
                }

                return number;
            }
        }
    }
}
