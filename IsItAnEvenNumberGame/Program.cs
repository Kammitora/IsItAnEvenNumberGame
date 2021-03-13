using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItAnEvenNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var isSuccess = false;

            ConsoleTextColor("Yellow");
            Console.WriteLine("Witaj w programie 'Czy to jest liczba parzysta'! \nPodaj jakąś liczbę a program powie czy to jest liczba parzysta.\n\n");
            Console.ResetColor();

            while (!isSuccess)
            {
                ConsoleTextColor("Cyan");
                Console.Write("Podaj liczbę: ");
                Console.ResetColor();

                if (!int.TryParse(Console.ReadLine(), out int numberFromKeyboard))
                {
                    ConsoleTextColor("Red");
                    Console.Write("Błąd! Tylko liczby CAŁKOWITE!\n\n");
                    continue;
                }

                isSuccess = isEvenNumber(numberFromKeyboard);
                
            }

        }

        static void ConsoleTextColor(string color)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
        }

        static bool isEvenNumber(int number)
        {
            Console.Write($"Liczba {number} to liczba ");

            if (number % 2 == 0)
            {
                ConsoleTextColor("Green");
                Console.WriteLine("PARZYSTA.\n");
                Console.ResetColor();
            }
            else
            {
                ConsoleTextColor("Magenta");
                Console.WriteLine("NIEPARZYSTA.\n");
                Console.ResetColor();
            }
                return true;
        }
    }
}
