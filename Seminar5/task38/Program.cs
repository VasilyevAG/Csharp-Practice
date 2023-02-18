/*
Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33
*/

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble()*10, 2); // [-999,999]
Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
double max = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
        
}
double min = max;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
double result = max - min;
Console.WriteLine($"Разница между {max} и {min} равна {Math.Round(result, 2)}");
