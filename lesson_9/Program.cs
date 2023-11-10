using System;
namespace Homework
{
    class Homework
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("- - - Task 64 - - -");
            Task64(7);
            Console.WriteLine("- - - END Task 64 - - -");
            Console.WriteLine();
            Console.WriteLine("- - - Task 66 - - -");
            Console.WriteLine(Task66(1, 7));
            Console.WriteLine("- - - END Task 66 - - -");
            Console.WriteLine();
            Console.WriteLine("- - - Task 68 - - -");
            Console.WriteLine(Task68(3, 2));
            Console.WriteLine("- - - END Task 68 - - -");
        }

        public static void Task64(int N)
        {
            // Задайте значение N. Напишите программу, 
            // которая выведет все натуральные числа в 
            // промежутке от N до 1. Выполнить с помощью рекурсии.
            Console.WriteLine(N);
            if (N == 1) return;
            Task64(N - 1);
        }

        public static int Task66(int M, int N)
        {
            // Задайте значения M и N. 
            // Напишите программу, которая найдёт сумму
            // натуральных элементов в промежутке от M до N.
            if (M == N) return 0;
                
            int L = 0;
            if (M > N) L = Task66(M - 1, N);
            else L = Task66(M + 1, N);
            
            if (L == 0) L = N;
            return M + L;
        }

        public static int Task68(int n, int m)
        {
            // Напишите программу вычисления функции Аккермана 
            // с помощью рекурсии. Даны два неотрицательных числа m и n.
            // m = 2, n = 3 -> A(m,n) = 9
            // m = 3, n = 2 -> A(m,n) = 29

            if (n == 0) return m + 1;
            else
            {
                if ((n != 0) && (m == 0)) return Task68(n - 1, 1);
                else return Task68(n - 1, Task68(n, m - 1));
            }
        }
    }
}