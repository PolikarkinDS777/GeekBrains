// #47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерации и заполнения двумерного массива
double[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(10, 100) + rand.NextDouble();
        }
    }
    return array2D;
}

// Печать двумерного массива
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:#.00} \t");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Укажите количество строк: ");
int column = ReadData("Укажите количество столбцов: ");

double[,] arr2D = Fill2DArray(row, column);
Print2DArray(arr2D);