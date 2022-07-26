// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x точки А: ");
float x1 = float.Parse(Console.ReadLine());
Console.Write("Введите координату y точки А: ");
float y1 = float.Parse(Console.ReadLine());
Console.Write("Введите координату z точки А: ");
float z1 = float.Parse(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
float x2 = float.Parse(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
float y2 = float.Parse(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
float z2 = float.Parse(Console.ReadLine());

float dis = (x2 - x1) * (x2 - x1) +
            (y2 - y1) * (y2 - y1) +
            (z2 - z1) * (z2 - z1);
Console.Write(MathF.Sqrt(dis));            

// float distance(
//     float x1, float y1, float z1, 
//     float x2, float y2, float z2)
// {
//     float dis = (x2 - x1) * (x2 - x1) +
//                  (y2 - y1) * (y2 - y1) +
//                  (z2 - z1) * (z2 - z1);
//     return dis;             
// }
// float res = distance(3, 6, 8, 2, 1, -7);
// Console.Write(MathF.Sqrt(res));
// float ares = distance(7, -5, 0, 1, -1, 9);
// Console.Write(MathF.Sqrt(ares));