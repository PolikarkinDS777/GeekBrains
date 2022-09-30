//===================================================================================
// #54. Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
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

//Сортировка массива
int[,] UpdArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        List<int> row = new List<int>();

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            row.Add(arr[i, j]);
        }
        row.Sort();
        row.Reverse();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = row[j];
        }
    }
    return arr;
}

int[,] arr2D = Fill2DArray(5, 10);
Console.WriteLine("Исходный массив:");
Print2DArray(arr2D);
Console.WriteLine("Упорядоченный массив:");
UpdArr(arr2D);
Print2DArray(arr2D);