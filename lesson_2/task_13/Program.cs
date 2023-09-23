// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int number_position = 3;

if (number >= 100)
{
    // получаем количество разрядов числа
    int n = (int)Math.Log10(number) + 1;

    if (n > number_position)
    {
        while (n > 3)
        {
            number /= 10;
            n--;
        }
    }
    int found_number = number % 10;
    Console.Write(found_number);
}
else
{
    Console.WriteLine("Число не содержит нужной цифры");
}




