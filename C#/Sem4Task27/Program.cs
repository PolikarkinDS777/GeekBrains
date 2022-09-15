//========================================================================
// # Задача 27 Напишите программу, которая принимает на вход число и  
// выдаёт сумму цифр в числе.
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

int SumDigit1(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }

    return sum;
}

int number = ReadData("\nВведите число: ");

DateTime d = DateTime.Now;
int res1 = SumDigit1(number);
Console.WriteLine("Время" + (DateTime.Now - d));

PrintResult("Сумма цифр в числе = " + res1);