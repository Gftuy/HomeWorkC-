using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Mission
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("сколько будет чисел?");
            int value = int.Parse(Console.ReadLine());
            int min = int.MaxValue; 
            int val = -1;
            Console.WriteLine("Вводите числа");

            for (; value > 0; value--)
            {
                val = Convert.ToInt32(Console.ReadLine());
                min = min > val ? val : min;
            }
            Console.WriteLine("Минимальное число " + min);
            Console.ReadKey();
        }
    }
}
