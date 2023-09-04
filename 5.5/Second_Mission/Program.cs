using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Mission
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
        /// меняет слова заданом на перед.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string Reverse(string text)
        {
            string ReversString = null;
            foreach (var word in SplitText(text).Reverse())
            {
                ReversString += word + " ";
            }
            return ReversString;
        }
        /// <summary>
        /// Вывод и Ввод  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение. ");
            string reversWord = Reverse(Console.ReadLine());
            Console.WriteLine(reversWord);
            Console.ReadKey();
        }
    }
}
