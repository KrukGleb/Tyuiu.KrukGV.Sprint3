using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrukGV.Sprint3.Task5.V23.Lib
{
    public class DataService : ISprint3Task5V23
    {
        
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            //double temp = 0;
            double sum = 0;
            for(int i = startValue1; i <= stopValue1; i++)
            {
                for(int k = startValue2; k <= stopValue2; k++)
                {
                    sum += (Math.Pow(x, k) + 2) * Math.Cos(k);
                    //sum += temp;
                }
                break;

            }
            
            sum *= 3;
            return Math.Round(sum, 3);
            throw new NotImplementedException();
        }
    }
}