// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void ShowNatural(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNatural(n - 1);
}
Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNatural(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNatural(int m, int n)
{
    if(n >= m) return SumNatural(m + 1, n) + m;
    return 0;
}

Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равна: ");
if(m > n)
{
    int temp = m;
    m = n;
    n = temp;
} 
Console.WriteLine(SumNatural(m, n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return Akerman(m - 1, 1);
  else return Akerman(m - 1, Akerman(m, n - 1));
}

Console.WriteLine("Введите первое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A(m, n) = {Akerman(m, n)}");
*/