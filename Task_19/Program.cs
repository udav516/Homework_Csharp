// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string five = Console.ReadLine();

if(five[0] == five[4] || five[1] == five[3]){
    Console.WriteLine("да");
}
else
Console.WriteLine("нет");
