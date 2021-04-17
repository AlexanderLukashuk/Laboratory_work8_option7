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

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Введите число: ");
                input = Console.ReadLine();
                numbers[i] = int.Parse(input);
            }
        }
    }
}
