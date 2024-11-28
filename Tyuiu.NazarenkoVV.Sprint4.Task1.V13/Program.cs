using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NazarenkoVV.Sprint4.Task1.V13.Lib;

namespace Tyuiu.NazarenkoVV.Sprint4.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнил:  Назаренко В.В.| ";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                             *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #13                                                                  *");
            Console.WriteLine("* Выполнил: |   Назаренко В. В.                                                *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
            Console.WriteLine("* вычисляет, находится ли точка с координатами X,Y в заштрихованной области    *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.Write("Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение {0} элемента массива: ", i);
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
        