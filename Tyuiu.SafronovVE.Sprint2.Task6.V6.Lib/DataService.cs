using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SafronovVE.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res;

            switch (value1)
            {
                case 1: res = "пик"; break;
                case 2: res = "треф"; break;
                case 3: res = "бубен"; break;
                case 4: res = "черви"; break;
                default: throw new ArgumentException($"Масть должна быть от 1 до 4. Значение {value1}");
            }
            switch (value2)
            {
                case 6: res = "шестерка " + res; break;
                case 7: res = "семерка " + res; break;
                case 8: res = "восьмерка " + res; break;
                case 9: res = "девятка " + res; break;
                case 10: res = "десятка " + res; break;
                case 11: res = "валет " + res; break;
                case 12: res = "дама " + res; break;
                case 13: res = "король " + res; break;
                case 14: res = "туз " + res; break;
                default: throw new ArgumentException($"Достоинство карты должно быть от 6 до 14. Значение {value2}");
            }
            return res;
        }
    }
}
