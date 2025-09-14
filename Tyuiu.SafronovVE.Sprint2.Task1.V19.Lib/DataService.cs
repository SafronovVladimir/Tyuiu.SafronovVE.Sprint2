using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SafronovVE.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a != b) | (c == d);
            res[1] = (a < c) & (b > d);
            res[2] = (a >= b) || (c > d);
            res[3] = (a + 300 > d) && (c == b);
            res[4] = (a == b + 342)!;
            res[5] = (a >= c) ^ (b <= d);

            return res;
        }
    }
}
