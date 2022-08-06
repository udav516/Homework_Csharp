// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using System.Collections.Generic;

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество плоскостей: ");
int o = int.Parse(Console.ReadLine()!);
int[,,] array = new int[m, n, o];

static void Main(int[,,] array)
{
    Console.WriteLine(String.Join(" ", GenerateNumbers(2, 2, 2)));
}

static HashSet<int> GenerateNumbers(int x, int y, int z)
{
    if (x > 0 && y > 0 && z > 0) {}
    var tempSet = new HashSet<int>();
    while (tempSet.Count != x * y * z)
    {
        tempSet.Add(new Random().Next(10, 100));
    }
    return tempSet;
}
Main(array);




