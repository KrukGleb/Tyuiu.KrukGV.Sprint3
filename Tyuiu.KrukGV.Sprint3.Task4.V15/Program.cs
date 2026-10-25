
using Tyuiu.KrukGV.Sprint3.Task4.V15.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task4.V15
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить              *");
            Console.WriteLine("* значение функции y=((sin(x)+x)/x)+0.75                                  *");
            Console.WriteLine("* При х = 0 пропустить значение Полученные значения перемножать.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            var x1 = -5;
            var xn = 5;
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("xn = " + xn);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x1, xn);
            Console.WriteLine(res);
            
            Console.ReadKey();
        }
    }
}