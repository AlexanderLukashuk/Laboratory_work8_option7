using System;

namespace Task8var7
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 1. Ввести n чисел. Найти количество чисел на отрезке [10;20].
            
            string input;
            int arraySize;
            Console.Write("Введите размер массива: ");
            input = Console.ReadLine();
            arraySize = int.Parse(input);
            int[] numbers = new int[arraySize];
            Random rand = new Random();
            int temp = 0;

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = rand.Next(100);
                Console.Write($"{numbers[i]} ");

                /*Console.Write("Введите число: ");
                input = Console.ReadLine();
                numbers[i] = int.Parse(input);*/
            }
            Console.WriteLine();

            while (temp < arraySize)
            {
                if (numbers[temp] >= 10 && numbers[temp] <= 20)
                {
                    Console.Write($"{numbers[temp]} ");
                }
                temp++;
            }
            Console.WriteLine();

            //* 2. Решить уравнение ln x-x+1.8=0, х=[2;3], с шагом 0,025

            double x = 2;
            double y;
            double step = 0.025;

            while (x <= 3)
            {
                y = Math.Log(x, Math.E) - x + 1.8;
                x += step;
                //Console.WriteLine($"y = {y}");
                if (y == 0)
                {
                    Console.WriteLine($"Истина y({y}) = 0");
                }
                else
                {
                    Console.WriteLine($"Ложь y({y}) != 0");
                }
            }
        }
    }
}
