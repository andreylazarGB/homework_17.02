// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Clear();

Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());

int GetCubeNum(int num)
{
    int result = 0;
    for(int i = 1; i <= num; i++)
    {
        result = Convert.ToInt32(Math.Pow(i, 3));    
        Console.WriteLine($"Куб числа  {i} : {result}");     
    }
    return result;
}

GetCubeNum(a);

