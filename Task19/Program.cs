// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное натуральное число: ");
double n = Convert.ToDouble(Console.ReadLine());

double n1 = Math.Floor(n / 10000);
double n2 = Math.Floor((n / 1000) % 10);
double n3 = Math.Floor((n / 10) % 10);
double n4 = Math.Floor(n % 10);

if (n1 == n4 && n2 == n3)
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("нет");