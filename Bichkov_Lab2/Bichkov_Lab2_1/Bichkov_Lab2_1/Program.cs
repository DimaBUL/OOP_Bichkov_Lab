using System;

namespace Bichkov_Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Author : Bulah Dmitro; Group : IPZ-13 ; Mail : dimlahub@gmail.com \n");
            //Завдання 1//
            Console.WriteLine("1. Написати програму обчислення значень функції у заданій точці x. " +
                              "Значення x вводиться з консолі. Результат вивести на консоль. \n");

            int F;
            Console.Write("Введіть значення х : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                F = 4 * x - 1;
                Console.WriteLine("Функція F = " + F);
            }
            else if (x > 0)
            {
                F = 25 * x + 10;
                Console.WriteLine("Функція F = " + F);
            }
            else
            {
                F = 0;
                Console.WriteLine("Функція F = " + F);
            }

            Console.ReadKey();
            
        }
    }
}