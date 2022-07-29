// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double max = 0;
double min = 100;

double[] array = new double[5];
for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]} ");
    if(array[i] > max){
        max = array[i];
    }
    if(array[i] < min){
        min = array[i];
    }
}
double difference = max - min;
Console.Write($"-> {difference}");