// #66. Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

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

//Подсчет суммы
int RecSumMN(int numM, int numN)
{
    return numM == numN ? numN : numM + RecSumMN(numM + 1, numN);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");

if (numM == numN)
{
    PrintResult("Заданные числа равны");
}
else if (numM < numN)
{
    PrintResult("" + RecSumMN(numM, numN));
}
else
{
    PrintResult("" + RecSumMN(numN, numM));
}