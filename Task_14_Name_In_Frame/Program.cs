using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_Name_In_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите необходимый символ для рамки: ");
            string symbolForFrame = Console.ReadLine();

            int leghtName = name.Length;
            string horizontalBorder = "";
            int additionalSymbol = 2;

            for (int i = 0; i < leghtName + additionalSymbol; i++)
                horizontalBorder += symbolForFrame;

            Console.WriteLine(horizontalBorder);
            Console.WriteLine(symbolForFrame + name + symbolForFrame);
            Console.WriteLine(horizontalBorder);
        }
    }
}
