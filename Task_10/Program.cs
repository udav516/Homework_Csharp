// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int numb = 0;

numb = int.Parse(Console.ReadLine()!);
numb = (numb / 10) % 10;

Console.WriteLine(numb);

// int threeNumb = Convert.ToInt32(Console.ReadLine());
// string strNumb = Convert.ToString(threeNumb);
// Console.WriteLine(strNumb[1]);