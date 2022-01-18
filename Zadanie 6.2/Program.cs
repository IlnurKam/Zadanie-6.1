using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();
            bool b = true;
            str = str.Replace(" ", string.Empty);
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    b = false;
            }

            Console.WriteLine(((b) ? "Является" : "Не является") + " палиндромом");
            Console.ReadKey();
        }
    }
}