/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Нельзя использовать Math.Pow();
3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Clear();
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine()), i = 0;
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
while (i < B)
{
    result = result * A;
    i++;
}
Console.WriteLine($"Число A в степени B равно: {result}");
