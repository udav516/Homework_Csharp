// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Введите строку:");
int position1 = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите столбец:");
int position2 = int.Parse(Console.ReadLine()!) - 1;
int n = 3;
int m = 4;
int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}
if (position1 < 0 | position1 > m - 1 | position2 < 0 | position2 > n - 1)
{
    Console.WriteLine("Элемента нет в массиве");
}
else
{
    Console.WriteLine($"Значение элемента массива = {array[position1, position2]}");
}