//===================================================================================
// #17 Напишите программу, которая принимает на вход координаты точки (X и Y), причём 
// X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//===================================================================================


// общение с пользователем
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// вычисление
int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

    return -1;
}

// вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Введите x");
int y = ReadData("Введите y");

int res = QuarterTest(x, y);
PrintResult("Точка находится в четверти номер " + res);