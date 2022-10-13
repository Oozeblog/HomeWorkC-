// Домашняя работа № 1 к семинару 13.10.2022.

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine($"Число {n1} больше, чем число {n2}");
}

else
{
    Console.WriteLine($"Число {n1} меньше, чем число {n2}");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if(n2 > max)
{
    max = n2;
}

if(n3 > max)
{
    max = n3;
}
        
Console.WriteLine($"Максимальное из этих чисел - {max}");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine($"Число {num} является чётным");
}
else

{
    Console.WriteLine($"Число {num} является нечётным");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
int x = 1;
Console.Write($"Чётные числа от 1 до {N}: ");
while(index <= N)
{
    if(x % 2 == 0)
    {
        Console.Write($"{x} ");
    }

    
index++;
x++;
}