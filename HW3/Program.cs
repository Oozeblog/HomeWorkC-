// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Вариант 1:
/*
void Polindrome5(int num)
{
    if( num % 10 == num / 10000 && (num/10) %10 == (num/1000)%10)
    {
        Console.WriteLine("Да. Это число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Нет. Это число не является палиндромом.");
    }
}
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99999 || num < 10000)
{
    Console.WriteLine("Это не пятизначное число!");
}
else
{
    Polindrome5(num);
}
*/

//Вариант 2 (Без ограничения по пятизначным числам):

void Polindrome(int num)
{
    int result = 0;
    int num2 = num;
    while(num2 > 0)
    {
        result = result*10 + num2 % 10;
        num2 = num2 / 10;
    }
    if(result == num)
    Console.WriteLine("Да. Это число является палиндромом.");
    else
    Console.WriteLine("Нет. Это число не является палиндромом.");
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Polindrome(num);

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double dist = Math.Sqrt(x*x + y*y + z*z);
    return dist;
}

Console.WriteLine("Введите координаты первой точки по оси х: ");
double x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси y: ");
double y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки по оси z: ");
double z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси х: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси y: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси z: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x, y, z, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {Math.Round(res, 2)}");
*/

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    int i = 1;
    Console.Write($"Кубы чисел от 1 до {n}: ");
    while(i <= n)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1)
{
    Console.WriteLine("Это некорректное число. Введите число больше единицы: ");
    n = Convert.ToInt32(Console.ReadLine());    
}
Cube(n);
*/