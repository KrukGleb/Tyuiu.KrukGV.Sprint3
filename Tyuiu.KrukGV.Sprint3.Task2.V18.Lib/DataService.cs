using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrukGV.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            var k = startValue;
            double mult = 1;
            var cosx = Math.Cos(value);
            do
            {
                
                var temp = Math.Pow( (double) k/8, 3);

                mult *= (cosx + temp);
                k++;

            } while (k <= stopValue);
               
            return Math.Round(mult, 3);
        }
    }
}