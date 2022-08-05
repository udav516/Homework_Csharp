// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int min = 0;
int sum = SumElements(array, 0);
for (int i = 1; i < m; i++)
{
  int temp = SumElements(array, i);
  if (sum > temp)
  {
    sum = temp;
    min = i;
  }
}

Console.WriteLine($"\n{min+1} - строкa с наименьшей суммой ({sum}) элементов ");


int SumElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < n; j++)
  {
    sum += array[i,j];
  }
  return sum;
}