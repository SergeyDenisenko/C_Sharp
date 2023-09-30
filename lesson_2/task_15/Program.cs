// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int day_week = int.Parse(Console.ReadLine());
if (day_week == 6 || day_week == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будний");
}