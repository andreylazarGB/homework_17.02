// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double[] ArrayA = {3, 6, 8};
double[] ArrayB = {2, 1, -7};

double[] ArrayC = {7, -5, 0};
double[] ArrayD = {1, -1, 9};

double GetDistance(double[] Array1, double[] Array2)
{
    double x = 0;
    double result = 0;
    for(int i = 0; i < Array1.Length; i++)
    {
        x = x + Math.Pow(Array1[i]-Array2[i], 2);
    }
    result = Math.Sqrt(x);
    return Math.Round(result, 2, MidpointRounding.ToZero);
}

Console.WriteLine($"Растояние между точками A и B : {GetDistance(ArrayA, ArrayB)}");
Console.WriteLine();
Console.WriteLine($"Растояние между точками C и D : {GetDistance(ArrayC, ArrayD)}");

