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
            string fullName = "Пушкин Алекснадр Сергеевич";                       //1) Первое задание  
            byte age = 16;                                                        //   Создание переменных и вывод     
            string email = "Pushkin@yandex.ru";
            double prograBall = 3.545;
            double mathBall = 4.233;
            double physicsBall = 4.912;

            Console.WriteLine($"Ф.И.О:-> {fullName} \nВозраст:-> {age} \nПочта:-> {email}" +
                $"\nБаллы по программированию:-> {prograBall} \nБаллы по математике:-> {mathBall}" +
                $"\nБаллы по физике:-> {physicsBall}");
            Console.ReadKey();

            //2) Задание 2
            //Реализация подсчёта количества баллов по всем предметам

            var avgBall = (prograBall + mathBall + physicsBall) / 3;
            var sumBall = prograBall + mathBall + physicsBall;

            Console.WriteLine($"{prograBall} + {mathBall} + {physicsBall} = {sumBall}");
            Console.WriteLine($"({prograBall} + {mathBall} + {physicsBall}) / 3 = {avgBall}");
            Console.ReadKey();


                
        }
    }
}
