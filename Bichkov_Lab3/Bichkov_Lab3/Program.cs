using System;

namespace Bichkov_Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Author : Bulah Dmitro; Group : IPZ-13 ; Mail : dimlahub@gmail.com \n");
            
            //Завдання 1//
            /* 2. Створити масив для зберігання значень зросту студентів групи (20 чоловік).
             Заповнити масив за допомогою класу Random цілими числамив діапазоні від 160 до 190 включно.  
             Відсортувати масив і вивести на консоль його елементи.*/
           
            Random rand = new Random();
           
            int min = 160;
            int max = 190;
            int[] masi = new int[20];
            Console.WriteLine("Завдання 1. \n");
            Console.Write("Вхідний масив : " + "[ ");
            for (int i=0; i < 20; i++)
            {
                int val = rand.Next(min, max);
                masi[i] = val ;
                Console.Write(masi[i] + " "); 
            }
            Console.WriteLine("]");
           
            Array.Sort(masi);              //Сортування масиву
           
            Console.WriteLine(); 
            Console.Write("Вихідний масив: ");
            Console.Write("[ ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(masi[i] + " ");
            }
            Console.WriteLine("]");
            Console.WriteLine();
            
            
            //Завдання 2//
            /* 3. Є прямокутний масив розмірністю (5x5).
            Визначити суму всіх елементів третього рядка  і  суму всіх елементів першого стовпчика.*/


            int sum_row = 0;
            int sum_col = 0;
            Console.WriteLine("Завдання 2. \n");

            int[,] mas =         //Масив розмірності 5х5
            {
                {1, 5, 10, 25, 3},
                {5, 2, 11, 1, 9},
                {6, 7, 34, 2, 1},
                {8, 5, 2, 20, 14},
                {17, 13, 2, 1, 0},
            };
            
            Console.WriteLine("Виведення елементів масиву 5 x 5: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(String.Format("{0,3}", mas[i, j]));
                    
                }
                Console.WriteLine( );
            }
            Console.WriteLine();
            
            //Додавання третього рядка
            for (int x = 0; x < 5; x++)
            {
                sum_row += mas[2, x];
                Console.Write(" " +sum_row);
            }
            Console.WriteLine();
            
            //Додавання першого стовпця
            for (int c = 0; c < 5; c++)
            {
                sum_col += mas[c, 0];
                Console.Write(" " +sum_col);
            }
            Console.WriteLine();
            
            //Виведення суми
            Console.WriteLine("Сума третього рядка = " + sum_row);
            Console.WriteLine("Сума першого стовпчика = " + sum_col);
            Console.WriteLine();
            
            
            //Завдання 3//
            /* 5. Створити масив з трьох цілих чисел і ініцілізувати при створенні. Визначити  мінімальне і максимальне число.
             Застосувати методи класу Math. Результати вивести на консоль.*/


            int[] arr = new int[3] {10, 2, 7};
            Console.WriteLine("Завдання 3. \n");
            Console.Write("Масив arr: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            
            //Знаходження максимального елемента масиву
            int max_1 = Math.Max(arr[0], arr[1]);  //Порівняння 1го і 2го елементів
            int max_2 = Math.Max(arr[2], max_1);   //Порівняння 1го і 2го елементів
            
            Console.WriteLine("Максимальний елемент масиву arr = " + max_2);
            int min_1 = Math.Min(arr[0], arr[1]);  //Порівняння 1го і 2го елементів
            int min_2 = Math.Min(arr[2], min_1);   //Порівняння 1го і 2го елементів
            
            Console.WriteLine("Мінімальний елемент масиву arr = " + min_2);
            Console.WriteLine();
            
            
            //Завдання 4//
            /* 7.Знайти методом лінійного пошуку максимальний і мінімальний елементи в масиві {4,5,2,3,8,7,6,1}*/

            int maxi, mini;

            int[] arra = new int[] {4, 5, 2, 3, 8, 7, 6, 1};
            Console.WriteLine("Завдання 4. \n");
            //Виведення масиву в консоль
            Console.Write("Масив: ");
            for (int j = 0; j < arra.Length; j++)
            {
                Console.Write(arra[j] + " ");
            }
            Console.WriteLine();

            mini = arra[0];
            maxi = arra[0];
            for (int i = 0; i < arra.Length; i++)
            {//Знаходження макс. елемента
                if (arra[i] > maxi)
                {
                    maxi = arra[i];
                }
                //Знаходження мін. елемента
                if (arra[i] < mini)
                {
                    mini = arra[i];
                }

            }
            Console.WriteLine("Максимальний елемент масиву: " + maxi);
            Console.WriteLine("Мінімальний елемент масиву: " + mini);

            Console.ReadKey();
        }
    }
}