// #66. Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке между M и N.

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

//Выдает требуемые числа
string RecMN(int numM, int numN)
{
    return numM == numN ? numN + "" : numM + " " + RecMN(numM + 1, numN);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");

if (numM == numN)
{
    PrintResult("Заданные числа равны");
}
else if (numM < numN)
{
    PrintResult(RecMN(numM, numN));
}
else
{
    PrintResult(RecMN(numN, numM));
}