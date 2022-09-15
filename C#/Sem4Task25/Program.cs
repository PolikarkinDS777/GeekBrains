//========================================================================
// # Задача 25 Напишите программу, которая принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
//========================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

long Pow1(int A, int B)
{
    long res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}

double Pow2(double A, double B)
{
    return Math.Pow(A, B);
}

int numA1 = ReadData("Введите число A:");
int numB1 = ReadData("Введите степень, число B:");

DateTime d1 = DateTime.Now;
PrintResult("Число A в натуральной степени числа B:" + Pow1(numA1, numB1));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PrintResult("A в степени B через Math:" + Pow2(numA1, numB1));
Console.WriteLine(DateTime.Now - d2);