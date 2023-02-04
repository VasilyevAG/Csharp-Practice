/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
/*int b = 0;*/
if (a / 100 != 0) {
   while (a / 1000 != 0)
    {
    a = a / 10;
    }
    Console.WriteLine(a % 10);}
else 
Console.Write("Третьей цифры нет");
