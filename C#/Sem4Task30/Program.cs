//========================================================================
// # Задача 30 Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке
//========================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] GenerArray(int arrLen)
{
    int[] array = new int[arrLen];
    Random rnd = new Random();
    for (int i = 0; i < arrLen; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

PrintArray(GenerArray(ReadData("Введите число:")));