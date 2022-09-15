//===================================================================================
// #19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//===================================================================================

int ReadDf(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

bool TestPalindrom(int pal)
{
    if ((pal / 10000 == pal % 10) && ((pal / 1000) % 10) == ((pal / 10) % 10))
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintDf(int pal)
{

    if (TestPalindrom(pal))
    {
        Console.WriteLine("Является палиндромом");
    }
    else
    {
        Console.WriteLine("Не является палиндромом");
    }

}

int pal = ReadDf("Введите 5-значное число:");
if (pal >= 10000 && pal < 100000)
{
    PrintDf(pal);
}
else
{
    Console.WriteLine("Число должно быть 5-значным!");
}