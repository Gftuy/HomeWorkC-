using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в будущей матрице: ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в будущей матрице: ");
            int column = int.Parse(Console.ReadLine());

            int[,] arr = new int[line, column]; 
            int sum = 0;

            Random rand = new Random();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr[i, j] = rand.Next(100);
                    Console.Write($"{arr[i, j]} ");
                    sum += arr[i , j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех чисел равна = {sum}");
            Console.ReadKey();
        }
        
    }
}
