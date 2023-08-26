using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Mission
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте. \nСколько у вас карт в колоде???\n");
            int handCards = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= handCards; i++)
            {
                Console.Write("Введите номинал карты:\n");
                string handValue = Console.ReadLine();

                switch (handValue)
                {
                    case "2":
                    case "J":
                        sum += 2;
                        break;
                    case "3":
                    case "Q":
                        sum += 3;
                        break;
                    case "4":
                    case "K":
                        sum += 4;
                        break;
                    case "5":
                        sum += 5;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                        sum += 10;
                        break;
                    case "T":
                        sum += 11;
                        break;
                    default:
                        Console.WriteLine("Допустимы номиналы 2-10, J, Q, K, T");
                        i--;
                        break;
                }
            }
            Console.WriteLine("Сумма карт на руках: " + sum);
            if (sum < 21)
            {
                Console.WriteLine($"Вы проиграли. \nУ вас не хватает очков.");
            }
            else
            {
                Console.WriteLine($"Вы выиграли.");
            }
            Console.ReadLine();
        }
    }
}
