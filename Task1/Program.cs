using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string text = Console.ReadLine();
            string[] words = text.Split();
            string w1 = words[0];
            foreach (string item in words)
            {
                if (w1.Length < item.Length)
                {
                    w1 = item;
                }
            }
            Console.WriteLine(w1);
            Console.ReadKey();
        }
    }
}
