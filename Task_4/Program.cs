// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int numberA = 0;
int numberB = 0;
int numberC = 0;

numberA = int.Parse(Console.ReadLine()!);
numberB = int.Parse(Console.ReadLine()!);
numberC = int.Parse(Console.ReadLine()!);


if(numberA > numberB){
    if(numberA > numberC){
        Console.Write(numberA);
    }
    else
    Console.Write(numberC);              
}
else if(numberB > numberC){
    Console.Write(numberB);
}                  
else
Console.Write(numberC);
                  


