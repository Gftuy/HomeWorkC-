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

            Console.WriteLine("Если вы хотите выйти из игры введите 0");
            Console.WriteLine("какой диапазон? ");
            int value = int.Parse(Console.ReadLine());
            int vau;
            int number = rand.Next(value);
                                                                  //Я так и не понял как реализовать строчку 5 в задание
            for (int i = 1; i < value; i++)                       // только смог реализовать с 0
            {
                while (1 == 1)
                {
                    Console.WriteLine("\nВведите число: ");
                    vau = Convert.ToInt32(Console.ReadLine());
                    if (vau == 0)
                    {
                        Console.WriteLine($"Вы проиграли \nБыло загаданное число {number} ");
                        Console.ReadLine();
                        break;
                    }
                    if (number < vau)
                    {
                        Console.WriteLine("Введенное число меньше загаданного");
                    }
                    else if (number > vau)
                    {
                        Console.WriteLine("Введенное число больше загаданного");
                    }
                    else
                    {
                        Console.WriteLine("Поздравляю вы угадали");
                        Console.ReadKey();
                        break;
                    }
                }
                break;
            }

        }
    }
}
