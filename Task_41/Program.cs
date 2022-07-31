// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите размер количества чисел: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];

void IntNumb(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

int Comparison(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
IntNumb(size);
string arrayString = string.Join(string.Empty, array);
Console.Write($"{arrayString} -> {Comparison(array)}");


