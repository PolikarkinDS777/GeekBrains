//===================================================================================
// #48. Задайте двумерный массив размера m на n, каждый элемент в массиве
// находится по формуле: Aₘₙ =m+n. Выведите полученный массив на экран.
//===================================================================================

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Mетод генерации и заполнение двумерного массива
int[,] Fill2DArrayMN(int numN, int numM)
{
    int[,] array2D = new int[numN, numM];

    for (int i = 0; i < numM; i++)
    {
        for (int j = 0; j < numN; j++)
        {
            array2D[i, j] = i + j;
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
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");
int[,] arr2D = Fill2DArrayMN(m, n);
Print2DArray(arr2D);