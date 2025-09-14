using Tyuiu.SafronovVE.Sprint2.Task1.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int a = 696;
        int b = 354;
        int c = 423;
        int d = 957;

        var res = ds.GetLogicOperations(a, b, c, d);

        Console.Title = "Спринт #2 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
        Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность: *");
        Console.WriteLine("* (True, False, True, False, True, False)                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);
        Console.WriteLine("C = " + c);
        Console.WriteLine("D = " + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}