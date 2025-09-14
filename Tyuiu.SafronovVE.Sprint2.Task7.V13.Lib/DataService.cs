using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SafronovVE.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if ( (x >= 0 && y <= 1 && y >= x - 1) || ((Math.Pow(x, 2) + Math.Pow(y, 2)) < 1 & (x >= 0 && x <= 1 && y >= -1)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
