using Tyuiu.PonkratevMM.Sprint3.Task5.V26.Lib;

namespace Tyuiu.PonkratevMM.Sprint3.Task5.V26;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #3                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #4                                        *");
        Console.WriteLine("* Вариант #13                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Расситать серию суммы по формуле:                 *");
        Console.WriteLine("* sumSeries += (Math.Pow(x, startValue1) +          *");
        Console.WriteLine("* + Math.Sin(startValue1)                           *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int x = 2;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 13;

        Console.WriteLine("Старт шага первой суммы ряда  = " + startValue1);
        Console.WriteLine("Старт шага второй суммы ряда  = " + startValue2);
        Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
        Console.WriteLine("Конец шага первой суммы ряда = " + stopValue2);




        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        Console.ReadKey();



    }

}