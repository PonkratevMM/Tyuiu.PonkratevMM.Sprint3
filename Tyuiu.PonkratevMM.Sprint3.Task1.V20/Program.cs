using Tyuiu.PonkratevMM.Sprint3.Task1.V20.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил Понкратьев М.М | ИИПб-26";
Console.WriteLine("*****************************************************");
Console.WriteLine("* Спринт #3                                         *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                  *");
Console.WriteLine("* Задание #1                                        *");
Console.WriteLine("* Вариант #20                                       *");
Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26   *");
Console.WriteLine("*****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                          *");
Console.WriteLine("* Написать программу используя цикл while, которая  *");
Console.WriteLine("* вычисляет сумму ряда по формуле                   *");
Console.WriteLine("* sumSeries += Math.Pow(1 / Math.Cos(startValue),2) *");
Console.WriteLine("*****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
Console.WriteLine("*****************************************************");

int startValue = 1;
int stopValue = 16;

Console.WriteLine("Старт шага =  " + startValue);
Console.WriteLine("Конец шага = " + stopValue);



Console.WriteLine("*****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
Console.WriteLine("*****************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue, stopValue));
Console.ReadKey();
