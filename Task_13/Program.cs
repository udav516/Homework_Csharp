// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int numb = 0;

numb = int.Parse(Console.ReadLine()!);

if (numb / 100 == 0){
    Console.Write("третьей цифры нет");
}
else if (numb / 1000 == 0){
    Console.WriteLine(numb = numb % 10);
}
else
Console.WriteLine(numb = (numb / 100) % 10);

// int threeNumb = Convert.ToInt32(Console.ReadLine());
// string threeNumbStr = Convert.ToString(threeNumb);
// if (threeNumbStr.Length > 2){
//     Console.WriteLine(threeNumbStr[2]);
// }
// else
// Console.WriteLine("третьей цифры нет");