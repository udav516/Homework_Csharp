// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int numberN = 0;
int i = 1;

numberN = int.Parse(Console.ReadLine()!);

while(i <= numberN){
    if (i % 2 == 0){
       Console.Write($"{i} "); 
    }
    i += 1;   
}

