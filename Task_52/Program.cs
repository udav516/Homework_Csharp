// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m, n];
double sum = 0;
string average = "";

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    sum = 0;
    for (int j = 0; j < m; j++)
    {
        sum += array[j, i];
    }
    average += string.Format("{0:f1} ", sum / m);
    Console.Write($"{sum} ");
}
Console.WriteLine($"Среднее арифметическое каждого столбца: {average} ");