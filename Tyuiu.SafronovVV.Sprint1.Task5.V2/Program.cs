using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SafronovVV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.SafronovVV.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Сафронов В. В. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                        *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #2                                                                        *");
            Console.WriteLine("* Выполнил: Сафронов Владислав Валерьевич | АСОиУб-23-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя исходные данные,            *");
            Console.WriteLine("* переводит температуру из Форенгейтов в градусы Цельсия.                           *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            
            Console.WriteLine("Введите температуру (F):");
            double temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine($"Температура равна {ds.FahrenheitToСelsius(temp)} градусов по Цельсия.");
            Console.ReadKey();



        }
    }
}
