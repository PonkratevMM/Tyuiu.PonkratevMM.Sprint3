using Tyuiu.PonkratevMM.Sprint3.Task0.V12.Lib;

namespace Tyuiu.PonkratevMM.Sprint3.Task0.V12;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #3                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #0                                        *");
        Console.WriteLine("* Вариант #12                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Написать программу используя цикл for, которая    *");
        Console.WriteLine("* вычисляет произведение ряда по формуле, при t = 1 *");
        Console.WriteLine("* по формуле Math.Pow(value, i) + 1.0 / (i + 1.0)   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int value = 1;
        int startValue = 1;
        int stopValue = 13;

       Console.WriteLine("Переменная Х = " + value);
       Console.WriteLine("Старт шага =  " + startValue);
       Console.WriteLine("Конец шага = " + stopValue);



        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue,stopValue));
        Console.ReadKey();

        

    }

}