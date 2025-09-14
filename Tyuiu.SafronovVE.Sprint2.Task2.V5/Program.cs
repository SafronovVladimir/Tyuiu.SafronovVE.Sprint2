using Tyuiu.SafronovVE.Sprint2.Task2.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x, y;

        Console.Title = "Спринт #2 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y                       *");
        Console.WriteLine("* в заштрихованной области.                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение X: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение Y: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        
        var res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine(res);

        Console.ReadLine();
    }
}