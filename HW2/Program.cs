// Домашняя работа № 1 к семинару 17.10.2022

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondOfThree(int number)
{
    int des = number % 100;
    number = des / 10;
    return number;
}

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondOfThree(num);

Console.WriteLine($"{result} - это вторая цифра в числе {num}");
