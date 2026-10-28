using Tyuiu.PonkratevMM.Sprint3.Task6.V24.Lib;

namespace Tyuiu.PonkratevMM.Sprint3.Task6.V24;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #3                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #6                                        *");
        Console.WriteLine("* Вариант #24                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых      *");
        Console.WriteLine("* чисел, принадлежащих числовому отрезку [17, 26]   *");
        Console.WriteLine("* количество всех делителей                         *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int startValue = 17;
        int stopValue = 26;

        Console.WriteLine("Старт шага  = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);





        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumTheDivisors(startValue, stopValue));
        Console.ReadKey();



    }

}