using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите число:");
            int value = int.Parse(Console.ReadLine());   
            
            if (value % 2 == 0) 
            {
                Console.WriteLine($"Число является четным: {value} ");
            }
            else 
            {
                Console.WriteLine($"Число является нечётное: {value} ");
            }
           
            Console.ReadKey();
        }
    }
}
