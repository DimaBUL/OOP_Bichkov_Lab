using System;

namespace Bichkov_Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Author : Bulah Dmitro; Group : IPZ-13 ; Mail : dimlahub@gmail.com \n");
            //Завдання 2//
            Console.WriteLine("2. Знайти найбільше з трьох чисел. Числа оголосити в коді  програми. \n");

            int a, b, c;
            a = 100;
            b = 23;
            c = 2;

            if (a > b && a > c)
            {
               Console.WriteLine("Число а = " + a + " є найбільшим серед трьох чисел."); 
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Число b = " + b + " є найбільшим серед трьох чисел."); 
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Число c = " + c + " є найбільшим серед трьох чисел.");
            }

            Console.ReadKey();
        }
    }
}