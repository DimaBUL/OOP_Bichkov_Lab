using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Author : Bulah Dmitro; Group : IPZ-13 ; Mail : dimlahub@gmail.com \n");
            //Завдання 1//
            Console.WriteLine("1. Реалізувати функцію обчислення суми та різниці двох цілих чисел \n");
            
            //Знаходження суми цілих чисел
            Console.WriteLine("Знаходження суми чисел");
            Console.WriteLine("Введіть перше число");
            int a1 = int.Parse(Console.ReadLine());  
            Console.WriteLine("Введіть друге число");
            int a2 = int.Parse(Console.ReadLine());
            int a_res = a1 + a2;
            Console.WriteLine("Сума чисел a1+a2= " + (a_res));
            Console.WriteLine();
            //Знаходження різниці цілих чисел
            Console.WriteLine("Знаходження різниці чисел");
            Console.WriteLine("Введіть перше число");
            int d1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введіть друге число");
            int d2 = int.Parse(Console.ReadLine());
            int d_res = d1 - d2;
            Console.WriteLine("Різниця чисел d1/d2= " + (d_res)) ;
            Console.WriteLine(" ");
            
            //Завдання 2//
            Console.WriteLine("2. Реалізувати функцію піднесення в квадрат добутку двох цілих чисел \n");
           
            Console.WriteLine("Введіть перше число");
            int b1 = int.Parse(Console.ReadLine());  
            Console.WriteLine("Введіть друге число");
            int b2 = int.Parse(Console.ReadLine());
            int dob = b1 * b2;
            Console.WriteLine("Добуток чисел a1*a2= " + dob);
            Console.WriteLine("Квадрат добутку двох цілих чисел = " + (Math.Pow(dob,2)));
            
            //Завдання 3//
            Console.WriteLine("3. Знайти значення поліному p=a*x^4-b*x^3+c*x+d. Значення  a,b,c,d – дійсні числа, " +
                              "ініціалізувати в коді, x ввести з консолі. \n ");
            
            Console.Write("Введіть число х : ");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = 10;
            double b = 3.5;
            double c = 54.432;
            double d = 21.31;
            double p = a * Math.Pow(x , 4) - b * Math.Pow(x , 3) + c * x + d;
            Console.WriteLine("Значення полінома p = " + p) ;
            Console.WriteLine();
            
            //Завдання 4//
            Console.WriteLine("4. Обчислити середнє арифметичне і середнє геометричне двох цілих чисел.  \n ");
            Console.Write("Введіть перше ціле число: ");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть друге ціле число: ");
            int h2 = Convert.ToInt32(Console.ReadLine());
            int mid_a = ((h1 + h2) / 2);
            double mid_g = Math.Sqrt(h1 * h2);

            Console.WriteLine("Середнє арифметичне двох цілих чисел : " + (mid_a));
            Console.WriteLine("Середнє геометричне двох цілих чисел : " + (mid_g));
            Console.WriteLine();
            
            //Завдання 5//
            Console.WriteLine("5. Вивести на консоль власні анкетні дані: Прізвище, ім'я, вік, група, курс.   \n ");
            Console.Write("Введіть ваше ім'я : ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write(" Введіть ваше прізвище : ");
            string surname = Convert.ToString(Console.ReadLine());
            Console.Write("Введіть ваш вік : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть номер вашої групи : ");
            int group = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть ваш курс : ");
            int course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Анкетні дані: ");
            Console.WriteLine("Прізвище : " + surname);
            Console.WriteLine("Імя : " + name);
            Console.WriteLine("Вік : " + age);
            Console.WriteLine("Група : " +  group);
            Console.WriteLine("Курс :  " + course);
            Console.ReadKey();

        }
    }
}