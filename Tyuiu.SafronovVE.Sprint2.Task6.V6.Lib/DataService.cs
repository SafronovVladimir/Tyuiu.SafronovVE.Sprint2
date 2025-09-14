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
                case 6: res = "Шестерка " + res; break;
                case 7: res = "Семерка " + res; break;
                case 8: res = "Восьмерка " + res; break;
                case 9: res = "Девятка " + res; break;
                case 10: res = "Десятка " + res; break;
                case 11: res = "Валет " + res; break;
                case 12: res = "Дама " + res; break;
                case 13: res = "Король " + res; break;
                case 14: res = "Туз " + res; break;
                default: throw new ArgumentException($"Достоинство карты должно быть от 6 до 14. Значение {value2}");
            }
            return res;
        }
    }
}
