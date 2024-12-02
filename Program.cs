using System;

class Program
{
    static void Main(string[] args)
    {
        Predicate<int> isPositive = num => num > 0;

        Console.WriteLine("Введіть число:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (isPositive(num))
        {
            Console.WriteLine($"{num} є додатним числом.");
        }
        else
        {
            Console.WriteLine($"{num} не є додатним числом.");
        }
    }
}
