using Tyuiu.SafronovVE.Sprint2.Task6.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int value1, value2;

        Console.Title = "Спринт #2 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
        Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string res;

        Console.WriteLine("Введите номер масти: ");
        value1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер достоинства карты: ");
        value2 = Convert.ToInt32(Console.ReadLine());

        if (value1 >= 1 && value1 <= 4 && value2 >=6 && value2 <=14)
        {
            res = "Это карта: " + ds.FindCardNameAndValue(value1, value2);
        }
        else
        {
            res = "Введено неверное значение!";
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();
    }
}