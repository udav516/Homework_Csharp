// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int M = 0;
int N = 0;

int.TryParse(Console.ReadLine(), out M);
int.TryParse(Console.ReadLine(), out N);



int AckFunction(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return AckFunction(M - 1, 1);
    else return AckFunction(M - 1, AckFunction(M, N - 1));
}
AckFunction(M, N);
int exit = AckFunction(M, N);
Console.Write(exit);