﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int mas = 0;
string tir = " ";
for(int i = 1; i <= num; i++){
    mas = i * i * i;
    Console.Write(mas + tir);
}