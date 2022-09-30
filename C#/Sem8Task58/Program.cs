//===================================================================================
// #58. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
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
            Console.Write($"{matr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

//Произведение матриц
int[,] MultMatr(int[,] firstArr, int[,] secArr)
{
    int[,] multMtrx = new int[firstArr.GetLength(0), secArr.GetLength(0)];

    for (int i = 0; i < secArr.GetLength(0); i++)
    {
        for (int j = 0; j < secArr.GetLength(1); j++)
        {
            multMtrx[i, j] = 0;
            for (int k = 0; k < secArr.GetLength(0); k++)
            {
                multMtrx[i, j] += firstArr[i, k] * secArr[k, j];
            }
        }
    }

    return multMtrx;
}

//Вывод данных
void PrintData(string line)
{
    Console.WriteLine(line);
}

int[,] firstArr = Fill2DArray(3, 3);
PrintData("\nМатрица 1:");
Print2DArray(firstArr);

int[,] secArr = Fill2DArray(3, 3);
PrintData("\nМатрица 2:");
Print2DArray(secArr);

PrintData("\nИх произведение:");
Print2DArray(MultMatr(firstArr, secArr));