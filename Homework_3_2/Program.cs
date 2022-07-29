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
            int yourNumber;

            Console.WriteLine(drawnNumber);

            var i = 1;
            while (true)
            {
                Console.Write("Podaj liczbę: ");
                var flag = false;
                try
                {
                    yourNumber = int.Parse(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = true;
                    throw ex;
                }
                finally
                {
                    if(flag)
                        Console.WriteLine("Coś się zepsuło!");
                }

                Console.WriteLine();

                if (yourNumber < drawnNumber && yourNumber >= lowerLimit )
                {
                    Console.WriteLine("Podana liczba jest za mała.");
                }
                else if (yourNumber > drawnNumber && yourNumber <= upperLimit)
                {
                    Console.WriteLine("Podana liczba jest za duża.");
                }
                else if (drawnNumber == yourNumber)
                {
                    Console.WriteLine($"Brawo! Udało Ci się trafić w {i} próbach.");
                    break;
                }
                else
                {
                    Console.WriteLine("Podaj liczbę z właściwego zakresu.");
                }

                i++;
            }
        }
    }
}
