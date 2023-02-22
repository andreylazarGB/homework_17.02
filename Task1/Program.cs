// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();

Console.WriteLine("Ведите число: ");
string Num = Console.ReadLine();

int[] Array = new int[Num.Length];
for (int i = 0; i < Num.Length; i++)
{
    Array[i] = int.Parse(Num[i] + "");
}

void GetNumber(int[] Number)
{
    int count = 0;
    for (int i = 0; i < Number.Length / 2; i++)
    {
        if (Number[i] == Number [(Number.Length - 1) - i])
            count ++;
        else
        break;
    }       
        if(count == Number.Length/2)
        Console.WriteLine($"Число {Num} является палиндромом");
        else 
        Console.WriteLine($"Число {Num} не является палиндромом");
}

GetNumber(Array);