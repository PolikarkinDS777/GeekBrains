// #63. Задайте значение N. Напишите программу, которая выдает все натуральные числа
// в промежутке от 1 до N.

 // Чтение данных из консоли
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

    string LineGenRec(int numN)
    {
        // Остановка
        if(numN==0)return "|";
        string outLine = LineGenRec(numN-1) + " " + numN;
        return outLine;
    }

    int numN = ReadData("Введите число N: ");
    string resultLine = LineGenRec(numN);
    PrintResult(resultLine);