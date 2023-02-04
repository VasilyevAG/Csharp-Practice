/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.Write("Вы ошиблись!\nВведите номер дня недели: ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 6 || a == 7)
    Console.Write("Это выходной ;)");
    else Console.Write("Это не выходной :(");
