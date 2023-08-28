using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifth_Mission
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            Console.WriteLine("Если вы хотите выйти из игры, просто нажмите Enter.");
            Console.WriteLine("Какой диапазон? ");
            int value = int.Parse(Console.ReadLine());
            int number = rand.Next(1, value + 1);
            while (true)
            {
                Console.WriteLine("\nВведите число (или просто нажмите Enter для выхода): ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"Вы проиграли\nБыло загаданное число {number}");
                    break;
                }
                else if (!int.TryParse(input, out int vau) || vau < 1 || vau > value)
                {
                    Console.WriteLine($"Введите число от 1 до {value} или оставьте поле пустым для выхода.");
                }
                else if (vau < number)
                {
                    Console.WriteLine("Введенное число меньше загаданного.");
                }
                else if (vau > number)
                {
                    Console.WriteLine("Введенное число больше загаданного.");
                }
                else
                {
                    Console.WriteLine("Поздравляю, вы угадали!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}