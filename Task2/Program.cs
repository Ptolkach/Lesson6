using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string text = Console.ReadLine();
            text = text.Replace(" ", "").ToLower();
            string text_new = "";
            foreach (char item in text)
            {
                text_new = item + text_new;
            }
            if (text == text_new)
            {
                Console.WriteLine("Палиндром!");
            }
            else 
            {
                Console.WriteLine("Не палиндром");
            }
            Console.ReadKey();

        }
    }
}
