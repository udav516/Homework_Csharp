// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)         k1*x+b1 = k2*x+b2   x:= (b2 - b1)/(k1 - k2)  double y = Convert.ToDouble(x);


double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void Coefficients()
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Введите коэффициент {i + 1} уравнения y = k * x + b");
        for (int j = 0; j < 2; j++)
        {
            if (j == 0)
            {
                Console.Write($"Введите коэффициент k: ");
            }
            else
            {
                Console.Write($"Введите коэффициент b: ");
            }
            coeff[i, j] = int.Parse(Console.ReadLine()!);
        }
    }
}

double[] Decision(double[,] coeff)
{
    if (coeff[0, 0] - coeff[1, 0] == 0)
    {
        Console.WriteLine($"Введите другой коэффициент k");

    }
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return crossPoint;
}
Coefficients();
Decision(coeff);
Console.Write($"Точка пересечений: ({crossPoint[0]}; {crossPoint[1]})");