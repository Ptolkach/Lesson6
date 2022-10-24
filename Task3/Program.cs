using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string text = Console.ReadLine();
            string text_new = text.Replace("{","").Replace("}","");
            Console.WriteLine(text_new);
            Console.ReadKey();
        }
    }
}
