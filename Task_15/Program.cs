// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day_numb = int.Parse(Console.ReadLine()!);

void dayWeek (int day_numb){
    if (day_numb == 6 || day_numb == 7){
        Console.Write("да");
    }
    else if (day_numb < 1 || day_numb > 7){
        Console.Write("Это не день недели!");
    }
    else
    Console.Write("нет");
}
dayWeek(day_numb);
