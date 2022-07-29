// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write($"Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int positive = 0;

int[] array = new int[size];
for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
    if (array[i] % 2 == 0){
        positive++;
    }  
}
Console.Write($"-> {positive}");


