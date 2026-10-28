using Tyuiu.PonkratevMM.Sprint3.Task7.V30.Lib;

namespace Tyuiu.PonkratevMM.Sprint3.Task7.V30;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил Понкратьев М.М | ИИПб-26";
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* Спринт #3                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
        Console.WriteLine("* Задание #7                                        *");
        Console.WriteLine("* Вариант #30                                       *");
        Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                          *");
        Console.WriteLine("* Написать программу, которая выводит таблицу       *");
        Console.WriteLine("* значений функции: F(x) = (5x + 2.5) /             *");
        Console.WriteLine("* / (sin(x) + 2) + 2x + 2 произвести табулирование  *");
        Console.WriteLine("* f(x) на заданном диапазоне [-5; 5] с шагом 1.     *");
        Console.WriteLine("* Произвести проверку деления на ноль. При делении  *");
        Console.WriteLine("* на ноль вернуть значение 0. Значения округлить    *");
        Console.WriteLine("* до двух знаков после запятой.                     *");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
        Console.WriteLine("*****************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага  = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);





        Console.WriteLine("*****************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
        Console.WriteLine("*****************************************************");

        double[] res = ds.GetMassFunction(startValue, stopValue);

        int count = 0;
        for (int i = 0; i <= stopValue - startValue; i++)
        {
            Console.WriteLine("| " + (startValue + i) + "  |  " + res[count] + "  |");
            count++;
        }
        Console.ReadKey();
    }

}



