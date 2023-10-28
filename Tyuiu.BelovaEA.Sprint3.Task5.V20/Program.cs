using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint3.Task5.V20.Lib;

namespace Tyuiu.BelovaEA.Sprint3.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20S                                                             *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя вложенные циклы, которая вычисляет         *");
            Console.WriteLine("* сумму ряда по формуле, при x = 5.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*      3     6                k                                           *");
            Console.WriteLine("*      --   --     /    x    \\                                            *");
            Console.WriteLine("*      \\    \\     |  ------   |                                           *");
            Console.WriteLine("* y =  /    /      \\ sin(x)  /                                            *");
            Console.WriteLine("*      --   --                                                            *");
            Console.WriteLine("*     i=1   k=1                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 6;


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"X = {x}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSumSeries(x, start1, start2, stop1, stop2));
            Console.ReadKey();
        }
    }
}
