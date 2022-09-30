//===================================================================================
// #56. Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//===================================================================================

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(1, 10);
        }
    }
    return array2D;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}

//Поиск наименьшей суммы
int FindMinRow(int[,] arr)
{
    int min = int.MaxValue;
    int outIndex = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndex = i + 1;
        }
    }

    return outIndex;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[,] arr2D = Fill2DArray(3, 5);
Console.WriteLine("Исходный массив:");
Print2DArray(arr2D);
PrintResult("Наименьшая сумма элементов в строке " + FindMinRow(arr2D));