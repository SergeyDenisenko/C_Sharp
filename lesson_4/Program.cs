using System;

public class Homework
{
    public static void Task25(double basis, double rate)
    {
        // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        // 3, 5 -> 243 (3⁵)
        // 2, 4 -> 16
        double total = 1;
        while (rate > 0)
        {
            total *= basis;
            rate--;
        }
        Console.WriteLine(total);
    }

    public static void Task27(int number)
    {
        // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        // 452 -> 11
        // 82 -> 10
        // 9012 -> 12
        int sum = 0;
        while (number > 0)
        {
            sum += (number % 10);
            number /= 10;
        }
        Console.WriteLine(sum);
    }

    public static void Task29()
    {
        // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
        // 6, 1, 33 -> [6, 1, 33]
        int arrayLength = 8;
        int[] array = new int[arrayLength];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 100);
        }

        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
            {
                Console.Write($"{array[i]}, ");
            }
            else
            {
                Console.Write(array[i]);
            }
        }
        Console.Write("]");
    }

    public static void Main(string[] args)
    {
        Task25(2, 4);
        Task27(9012);
        Task29();
    }
}