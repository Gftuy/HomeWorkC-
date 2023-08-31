using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Missions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в будущей матрице: ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в будущей матрице: ");
            int column = int.Parse(Console.ReadLine());

            int[,] arrA = new int[line, column];
            int[,] arrB = new int[line, column];
            int[,] arrC = new int[line, column];

            Random rand = new Random();
            Console.WriteLine("1-я матрица:");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arrA[i, j] = rand.Next(-10 , 10);
                    Console.Write($"{arrA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("2-я матрица:");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arrB[i, j] = rand.Next(-10 , 10);
                    Console.Write($"{arrB[i, j]} ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сложенние матриц:");
            for (var i = 0; i < line; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    arrC[i, j] = arrA[i, j] + arrB[i, j];
                    Console.Write($"{arrC[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
