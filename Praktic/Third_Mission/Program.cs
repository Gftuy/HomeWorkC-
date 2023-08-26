using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Third_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");                    //Почему когда я ввожу не простое число
            int N = int.Parse(Console.ReadLine());                  //консоль закрывается и цикл заканчивается
                                                                    //даже не выводится что число не простое
            bool f = true;
            
            while (2 <= N - 1)
            {
                
                if (N % 2 == 0) 
                {
                    f = false;
                    break;
                }
                if (f)
                {
                    Console.WriteLine("Число простое\n");
                    
                }
                else
                {
                    Console.WriteLine("Число не простое\n");
                }
                
                Console.ReadKey();
            }  
        }
    }
}
