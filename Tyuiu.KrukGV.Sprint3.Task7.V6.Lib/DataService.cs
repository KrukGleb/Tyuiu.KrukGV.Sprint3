using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrukGV.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            var len = Math.Abs(stopValue - startValue) + 1;
            double[] res = new double[len];
            int x = 0;
            for (int i = 0; i < len; i++)
            {
                x = i + startValue;
                Console.WriteLine(x);
                res[i] = 3 * Math.Cos(x) / (4 * x - 0.5) 
                    + Math.Sin(x) 
                    - 5*x 
                    - 2;

                res[i] = Math.Round(res[i], 2);
                
                
            }
            return res;
            
        }
    }
}