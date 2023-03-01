/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
Console.WriteLine("Введите числа: ");
for (int i = 0; i < m; i++)
{
array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for (int i = 0; i < m; i++)
{
    if (array[i] > 0)
    {
        count++;
    }

}

Console.Write($"Количество чисел больше 0 равно: {count}");