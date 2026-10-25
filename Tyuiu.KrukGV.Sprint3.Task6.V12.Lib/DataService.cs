using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrukGV.Sprint3.Task6.V12.Lib
{
    public class DataService : ISprint3Task6V12
    {

        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            var sum_all = 0;
            for (int num = startValue; num <= stopValue; num++)
            {
                int sum = 0;

                for (int d = 1; d <= num; d++)
                    if (num % d == 0)
                        sum += d; 

                sum_all += sum;
            }
            return sum_all;
        }
    }
}