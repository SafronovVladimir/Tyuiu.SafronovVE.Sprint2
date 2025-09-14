using Tyuiu.SafronovVE.Sprint2.Task5.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startYear, n;
        startYear = 1;

        Console.Title = "Спринт #2 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch                  *");
        Console.WriteLine("* вычисляет требуемое значение и возвращает результат по условию:         *");
        Console.WriteLine("* С начала 1990 года по некоторый день прошло n месяцев и 2 дня.          *");
        Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите количество прошедших месяцев: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (n > 0 && n < 13)
        { 
        string res = ds.FindMonthName(startYear, n);
        Console.WriteLine("Месяц: " + res);
        }
        else
        {
            Console.WriteLine("Введено неверное количество месяцев. ");
        }
            Console.ReadLine();
    }
}