// #68. Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод вывода в консоль строки
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Вычисление функции Аккермана
int RecAckermann(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0 && numM > 0)
    {
        return RecAckermann(numM - 1, 1);
    }
    else
    {
        return RecAckermann(numM - 1, RecAckermann(numM, numN - 1));
    }
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
PrintResult("" + RecAckermann(numM, numN));