/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 100 || a > 999)
{
    Console.Write("Ошибка!\nВведите трёхзначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
}
int b = a / 10;
int c = b % 10;
Console.WriteLine(c);
