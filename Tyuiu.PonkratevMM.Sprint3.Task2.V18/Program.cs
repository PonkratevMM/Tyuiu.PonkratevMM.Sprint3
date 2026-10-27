using Tyuiu.PonkratevMM.Sprint3.Task2.V18.Lib;
namespace Tyuiu.PonkratevMM.Sprint3.Task2.V18;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #3                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #2                                        *");
        Console.WriteLine("* Вариант #18                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Написать программу используя цикл do...while,     *");
        Console.WriteLine("* которая вычисляет произведение ряда по формуле,   *");
        Console.WriteLine("* при х=1 multSeries += Math.Cos(value) +           *");
        Console.WriteLine("* + Math.Pow(startValue / 8, 3)                     *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int value = 1;
        int startValue = 1;
        int stopValue = 14;

        Console.WriteLine("Переменная Х = " + value);
        Console.WriteLine("Старт шага =  " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);



        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();



    }

}