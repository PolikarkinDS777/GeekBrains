//===================================================================================
// #22 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
//===================================================================================

//получаем число
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//вычисления
string LineNum(int numN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i <= numN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    return outLine;
}
//результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число:");
PrintResult(LineNum(num, 1));
PrintResult(LineNum(num, 2));