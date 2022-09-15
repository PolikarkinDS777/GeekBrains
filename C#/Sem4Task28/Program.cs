//========================================================================
// # Задача 28 Напишите программу, которая принимает на вход число N и  
// выдаёт произведение чисел от 1 до N
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

long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

int number = ReadData("Введите число: ");

long factorial = CalculateFactorial(number);
PrintResult("Факториал равен: " + factorial);