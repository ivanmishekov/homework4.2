/*
Задача 2: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/


int number = InputInt("Введите число");
int len = Count(number);
Sum(number, len);


int InputInt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}


int Count(int num)
{
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}


void Sum(int a, int b)
{
    int sum = 0;
    for (int i = 1; i <= b; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    Console.WriteLine($"Сумма цифр числа {number} = {sum}");
}