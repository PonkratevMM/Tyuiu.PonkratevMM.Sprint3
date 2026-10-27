using Tyuiu.PonkratevMM.Sprint3.Task3.V25.Lib;

namespace Tyuiu.PonkratevMM.Sprint3.Task3.V25;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #3                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #3                                        *");
        Console.WriteLine("* Вариант #25                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Используя цикл foreach подсчитать минимальное     *");
        Console.WriteLine("* количество букв u, находящихся на соседних        *");
        Console.WriteLine("* позициях в строке: kjhgfuu gujut dtuu             *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        string value = "kjhgfuu gujut dtuu";
        char chr = 'u';

        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine("Искомый символ = " + chr);

        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Минимальное количество букв u = " + ds.GetMinCharCount(value, chr));
        Console.ReadKey();



    }

}