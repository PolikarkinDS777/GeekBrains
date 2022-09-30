//===================================================================================
// #60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.
//===================================================================================

// Печать трехмерного массива
void Print3DArray(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив числами
int[,,] Fill3DArray(int countI, int countJ, int countK)
{
    int[,,] arr3D = new int[countI, countJ, countK];
    int num = 10;

    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                arr3D[i, j, k] = num++;
            }
        }
    }
    return arr3D;
}

int[,,] array3D = Fill3DArray(3, 2, 4);
Print3DArray(array3D);