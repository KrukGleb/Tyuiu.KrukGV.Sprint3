using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrukGV.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 0;
            double prod = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                    continue;
                y = ((Math.Sin(i) + i) / i) + 0.75;
                prod *= y;
            }
            return Math.Round(prod, 3);
        }

       
    }
}