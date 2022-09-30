//===================================================================================
// #52. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
//===================================================================================


// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
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
            Console.Write($"{matr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

//считаем среднее арифметическое
double[] Count(int[,] matr)
{
    double[] array = new double[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            array[j] = array[j] + matr[i, j];
        }
    }
    for (int k = 0; k < matr.GetLength(1); k++)
    {
        array[k] = Math.Round((array[k] / (double)matr.GetLength(0)), 2);
    }
    return array;
}

//Печатаем одномерный массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int row = ReadData("Укажите количество строк: ");
int column = ReadData("Укажите количество столбцов: ");

int[,] arr2D = Fill2DArray(row, column, 1, 9);
Print2DArray(arr2D);

double[] outArray = Count(arr2D);
Print1DArr(outArray);