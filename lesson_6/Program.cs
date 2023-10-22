using System;

public class Homework
{
    public static void Task41()
    {
        // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223-> 3
        Console.Write("Введите числа через запятую: ");
        string[] input = Console.ReadLine().Split(",");
        int counter = 0;
        for (int i=0; i<input.Length; i++)
        {
            int number = int.Parse(input[i]);
            if (number > 0) counter++;
        }
        Console.WriteLine(counter);
    }

    public static void Task43()
    {
        // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
        // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
        Console.Write("Введите координаты первой прямой через запятую: ");
        string[] line1 = Console.ReadLine().Split(",");
        Console.Write("Введите координаты второй прямой через запятую: ");
        string[] line2 = Console.ReadLine().Split(",");
        double[] b = {double.Parse(line1[0]), double.Parse(line2[0])};
        double[] k = {double.Parse(line1[1]), double.Parse(line2[1])};

        double x = (b[1] - b[0])/(k[0] - k[1]);
        double y = k[0] * x + b[0];
        Console.WriteLine($"({x}; {y})");
    }

    public static void Main(string[] args)
    {
        Task41();
        Task43();
    }
}