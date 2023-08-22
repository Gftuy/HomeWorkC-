using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_2
{
    internal class Program
    {
        static void Main()
        {
            /*string FullName = "Пушкин Алекснадр Сергеевич";                       //1) Первое задание  
                                                                                    //   Создание переменных и вывод
            byte Age = 16;
            string Email = "Pushkin@yandex.ru";*/
            double PrograBall = 3.545;
            double MathBall = 4.233;
            double PhysicsBall = 4.912;

            /*Console.WriteLine($"Ф.И.О:-> {FullName} \nВозраст:-> {Age} \nПочта:-> {Email}" +
                $"\nБаллы по программированию:-> {PrograBall} \nБаллы по математике:-> {MathBall}" +
                $"\nБаллы по физике:-> {PhysicsBall}");
            Console.ReadKey();*/

            //2) Задание 2
            //Реализация подсчёта количества баллов по всем предметам

            var AvgBall = (PrograBall + MathBall + PhysicsBall) / 3;
            var SumBall = PrograBall + MathBall + PhysicsBall;

            Console.WriteLine($"{PrograBall} + {MathBall} + {PhysicsBall} = {SumBall}");
            Console.WriteLine($"({PrograBall} + {MathBall} + {PhysicsBall}) / 3 = {AvgBall}");
            Console.ReadKey();


                
        }
    }
}
