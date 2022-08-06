// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int M = 0;
int N = 0;

int.TryParse(Console.ReadLine(), out M);
int.TryParse(Console.ReadLine(), out N);
int sum = 0;

void SumFunction(int M, int N, int sum)
{
    sum += N;
    if (M >= N)
    {
        Console.Write($"{sum}");
        return;
    }
    SumFunction(M, N - 1, sum);

}
SumFunction(M, N, sum);