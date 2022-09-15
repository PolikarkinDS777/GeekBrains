//========================================================================
// # Задача 29 Напишите программу, которая задаёт массив из 8 элементов и  
// выводит их на экран. Ввести с клавиатуры длину массива и диапазон
// значений элементов
//========================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] GenArray(int arrLen, int start, int stop)
{
    int[] outArray = new int[arrLen];
    Random rnd = new Random();
    for (int i = 0; i < arrLen; i++)
    {
        outArray[i] = rnd.Next(start, stop);
    }
    return outArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int numArr = ReadData("\nВведите длину массива:");
Console.WriteLine("Задайте границы диапазона значений элементов:");
int numStart = ReadData("Введите начальную границу:");
int numStop = ReadData("Введите конечную границу:");

PrintArray(GenArray(numArr, numStart, numStop));