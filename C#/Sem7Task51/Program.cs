//===================================================================================
// #51. Задайте двумерный массив. Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1;1) и т.д.)
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

//Вычисление суммы
int DiagonalSum(int[,] arr)
{
    int length = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        sum += arr[i, i];
    }

    return sum;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

int row = ReadData("Укажите количество строк: ");
int column = ReadData("Укажите количество столбцов: ");

int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);
PrintResult("Сумма главной диагонали: ", DiagonalSum(arr2D).ToString());