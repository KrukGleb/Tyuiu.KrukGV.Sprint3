
using Tyuiu.KrukGV.Sprint3.Task7.V6.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task7.V6
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            var startValue = -5;
            var stopValue = 5;
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            int len = valueArray.Length;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|\tX\t|\tf(x)\t|");
            Console.WriteLine("+-------------------------------+");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0,8:d}\t|\t{1, 5:f2}\t|", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+-------------------------------+");
            Console.ReadKey();
        }
    }
}