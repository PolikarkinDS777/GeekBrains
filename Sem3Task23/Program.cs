//===================================================================================
// #23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//===================================================================================

Console.WriteLine("\nVariant 1.");
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;   
    while(i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }

    outLine = outLine + Math.Pow(numberN, pow);      
    return outLine;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N:");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 3));