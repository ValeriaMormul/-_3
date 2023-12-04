using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число для таблицы умножения: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Таблица умножения для числа {number}:");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }
    }
}