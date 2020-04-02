using System;

namespace Bichkov_Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Author : Bulah Dmitro; Group : IPZ-13 ; Mail : dimlahub@gmail.com \n");
            
            //Завдання 3//
            Console.WriteLine("3. Написати програму, яка в залежності від порядкового номера дня тижня (1,2,...7)" +
                              " виводить на екран його назву (понеділок,...) \n");
            
            Console.Write("Введіть число від від порядкового номера дня тижня (1,2,...7)  " +
                          "(наприклад 1 - понеділок...) : ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                {
                    Console.WriteLine("Ви вказали число : " + x + "  ." + "Отже, отримуєте: Понеділок!");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Ви вказали число : " + x + "  ." + "Отже, отримуєте: Вівторок!");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Ви вказали число : " + x + "  ." + "Отже, отримуєте: Середу!");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Ви вказали число : " + x + "  ." + "Отже, отримуєте: Четверг!");
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Ви вказали число : " + x + "  ." + "Отже, отримуєте: Пятницю!");
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Ви вказали число : " + x + "  ." + "Отже, отримуєте: Суботу!");
                    break;
                }
                case 7:
                {
                    Console.WriteLine("Ви вказали число : " + x + "  ." + "Отже, отримуєте: Воскресіння!");
                    break;
                }
                default:
                {
                    Console.WriteLine("Ви вказали неправильне число дня тижня! ");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}