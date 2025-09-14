using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SafronovVE.Sprint2.Task3.V25.Lib
{
    public class DataService : ISprint2Task3V25
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(Math.Sin(Math.Pow(x, 3)) + Math.Pow((x + 1) / (x - 1), x), 3);
            }
            else if (x == 0)
            {
                return Math.Round(Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 3)) / (x - 3), 3);
            }
            else if (x > -29 && x < 2)
            {
                return Math.Round(Math.Pow(1 + 1 / Math.Pow(x, 2), x), 3);
            }
            else
            {
                return Math.Round(x + 15 + 12 / x * x, 3);
            }
        }
    }
}
