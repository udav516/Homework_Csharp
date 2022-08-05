// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// if (array[k, l] / 10 == 0)
// {
//     Console.Write($"0{array[k, l]} ");
// }
// else
//     Console.Write($"{array[k, l]} ");

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m, n];
int count = 1;
int i = 0;
int j = 0;

while (count <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

for (i = 0; i < array.GetLength(0); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] / 10 <= 0)
            Console.Write($"0{array[i, j]} ");

        else Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
