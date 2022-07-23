// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int numberA = 0;
int numberB = 0;

numberA = int.Parse(Console.ReadLine()!);
numberB = int.Parse(Console.ReadLine()!);

if(numberA > numberB){
    Console.Write(numberA);
}
else
Console.Write(numberB);
