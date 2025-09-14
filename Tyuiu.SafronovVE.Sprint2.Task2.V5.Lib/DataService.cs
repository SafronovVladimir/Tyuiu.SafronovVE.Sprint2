using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SafronovVE.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3 && x <= 5 && y >= 2 && y <= 5) || (x == 5 && y >= 5 && y <= 7) || (x >= 6 && x <= 8 && y >= 5 && y <= 10) || (x >= 3 && x <= 8 && y == 11) || (y == 12 && x >= 7 && x <= 10) || (x == 9 && y >= 3 && y <= 4) || (x >= 9 && x <= 12 && y >= 5 && y <= 6) || (x >= 11 && x <= 12 && y >= 3 && y <= 4) || (x == 13 && y >= 6 && y <= 8))
            {
                res = true;
            }
            else res = false;
            return res;
        }
    }
}