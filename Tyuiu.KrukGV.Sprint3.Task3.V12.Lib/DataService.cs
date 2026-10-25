using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KrukGV.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            var max = 0;
            var temp = 0;
            foreach (var c in value) 
            {
                if (c == item)
                    temp++;
                else
                    temp = 0;
                max = Math.Max(max, temp);

            }
            return max;
            
        }
    }
}