using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SafronovVV.Sprint1.Task6.V7.Lib;

namespace Tyuiu.SafronovVV.Sprint1.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Сафронов В.В. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Сафронов Владислав Валерьевич | АСОиУб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Напечатать все слова, удалив из них последнюю букву.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите предложение: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"* РЕЗУЛЬТАТ: {ds.DeleteLastLetter(a)}                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}
