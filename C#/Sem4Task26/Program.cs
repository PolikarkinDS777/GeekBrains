//========================================================================
// # Задача 26 Напишите программу, которая принимает на вход число и  
// выдаёт количество цифр в числе.
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

int DigitCount(int num)
{
    int count = 0;
    while(num > 0)
    {
        count += 1;
        num = num / 10;
    }

    return count;
}

int number = ReadData("Введите число: ");

DateTime d = DateTime.Now;
int res = DigitCount(number);
PrintResult("Количество цифр в числе = " + res);
Console.WriteLine(DateTime.Now - d);