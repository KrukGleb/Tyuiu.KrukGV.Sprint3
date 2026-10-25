
using Tyuiu.KrukGV.Sprint3.Task2.V18.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Крук Г. В. | НТм25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при х=1                                   *");
            Console.WriteLine("* prod (cos(1) + (k/8)^3), k=1 to 14                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var x = 1;
            var k1 = 1;
            var kn = 14;
            Console.WriteLine("x = " + x);
            Console.WriteLine("k1 = " + k1);
            Console.WriteLine("kn = " + kn);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetMultiplySeries(x, k1, kn);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}