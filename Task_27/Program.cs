// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
int sum = 0;
int res = 0;

while(numb != 0){
    sum = numb - numb % 10;
    res += numb - sum;
    numb /= 10;
}
Console.Write(res);