/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-999, 1000); // [-999,999]
}*/

/*void ReleaseArray(int[] array, sum)
{
  //int sum = 0;
  for (int i = 1; i < array.Length; i+= 2)
    sum = sum + array[i];
}*/

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-999, 1000); // [-999,999]
    //InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
//ReleaseArray(array, sum);
int sum = 0;
  for (int i = 1; i < array.Length; i+= 2)
    sum = sum + array[i];
Console.WriteLine($"Сумма элементов на нечётных позициях равна: {sum}");
