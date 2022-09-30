//===================================================================================
// #50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
//===================================================================================


// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(10, 100);
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

//проверка на наличие элемента
bool FindElemTest(int x, int y, int[,] arr)
{
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    {
        return true;
    }
    return false;
}

// вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int row = ReadData("Укажите количество строк: ");
int column = ReadData("Укажите количество столбцов: ");

int[,] arr2D = Fill2DArray(row, column);
Print2DArray(arr2D);

Console.WriteLine("Укажите позицию искомого элемента: ");
int x = ReadData("1) номер строки - ");
int y = ReadData("2) номер столбца - ");

PrintResult(FindElemTest(x, y, arr2D) ? "Искомый элемент: " + arr2D[x-1, y-1] : "Элемент в таблице нет");