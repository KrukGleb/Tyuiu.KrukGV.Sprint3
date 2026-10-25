using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrukGV.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                var temp = 1 / Math.Pow(value, i);
                sum += Math.Pow(temp, 2);

            }
            return sum;
        }
    }
}