// Домашняя работа № 2 к семинару 17.10.2022

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondOfThree(int number)
{
    int des = number % 100;
    number = des / 10;
    return number;
}

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100 || num > 999)
{
    Console.WriteLine("Это не трехзначное число!");
}
else
{
    int result = SecondOfThree(num);

    Console.WriteLine($"{result} - это вторая цифра в числе {num}");
}
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int digit)
{
    while(digit > 999)
    {
        digit = digit / 10;
    }
    digit = digit % 10;
    return digit;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num / 100 == 0)
{
    Console.WriteLine($"В данном числе нет третьей цифры.");
}
else
{
    int result = ThirdDigit(num);
    Console.WriteLine($"Если считать слева направо, то {result} - это третья цифра в числе {num}");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool DayWeek(int dayNum)
{
    if(dayNum == 6 || dayNum == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Введите цифру соответствующую дню недели(от 1 до 7): ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7)
{
    Console.WriteLine ("Эта цифра не соотвтствует дню недели!");
}
else
{
    bool result = DayWeek(num);
    Console.Write("Этот день является выходным - ");
    Console.WriteLine(result);
}
*/