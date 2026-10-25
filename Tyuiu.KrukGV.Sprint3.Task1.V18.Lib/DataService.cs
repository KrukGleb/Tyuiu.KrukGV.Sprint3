using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrukGV.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            var i = startValue;
            double sum = 0;
            while (i <= stopValue) 
            {
                var temp = Math.Sin(i) / 4;
                sum += Math.Pow(temp, 2);
                i++;
            }
            return Math.Round(sum, 3);
        }
    }
}