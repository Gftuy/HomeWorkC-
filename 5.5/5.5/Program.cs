using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _5._5
{
    internal class Program
    {
        /// <summary>
        /// Разделяет предложение на слова.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            return text.Split(' '); 
        }

        /// <summary>
        /// Вывод в строчку (слово)
        /// </summary>
        /// <param name="textSplit"></param>
        static void Vivod(string[] textSplit)
        {
            foreach (string word in textSplit)
            {
                Console.WriteLine(word);
            }
        }
        /// <summary>
        /// Выводит 2 метода на экран
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Введите предложение. ");
            Vivod(SplitText(Console.ReadLine()));
            Console.ReadLine();
        }

    }
}
