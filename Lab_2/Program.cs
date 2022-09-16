using System;

namespace Lab_2
{
    internal class Program
    {
        public static void Massiv(int n, int d)
        {
            double[] a = new double[n];
            double b = 0;
            if (d == 1)
            {
                Random r = new Random();

           
                Console.WriteLine("Одномерный массив: ");
                for (int i = 0; i < n; i++)
                {
                    a[i] = r.Next(0, 100);
                  
                    b = b + a[i];
                    Console.Write(a[i] + " ");

                }
                Console.WriteLine();
                
                double k = b / n;
                Console.WriteLine("Среднеарифметическое значение элементов массива = {0:F2}", k);
            }
            else if(d == 0)
            {


                
                Console.WriteLine("Одномерный массив: ");
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        
                    }
                   catch 
                    {
                        Console.WriteLine("Ошибка, введено не число");
                    }
                  
                    b = b + a[i];
                    Console.Write(a[i] + " ");

                }
                Console.WriteLine();
                double k = b / n;
                Console.WriteLine("Среднеарифметическое значение элементов массива = {0,C2}" +k);
            }
           
        }

        static void Main(string[] args)
        {
            
            try
            {
            
                Console.WriteLine("Введите количество элементов массива");
                int n = Convert.ToInt32(Console.ReadLine());
                try
                {
                perehod:
                    Console.WriteLine("Выберите цифру 1-Рандомные цифры элемента, 0-Ввести цифру вручную");
                    int d = Convert.ToInt32(Console.ReadLine());
                    if ((d == 0) ^ (d == 1))
                    {
                        Massiv(n, d);
                    }
                    else
                    {
                        Console.WriteLine("Выберите правильный вариант");
                        goto perehod;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка, введено не число");
                    
                }
            }
            catch
            {
                Console.WriteLine("Ошибка, введено не число");

            }
        }
    }
}