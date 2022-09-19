// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int length, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

bool EvenTest(int num)
{
    return (num % 2 == 0);
}

int EvenCount(int[] array)
{
int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (EvenTest(array[j])) 
        {
            count++;
        }
    }

    return count;
}

int[] array = FillArray(11, 100, 999);
Print1DArray(array);
EvenCount(array);
void PrintAnswer(int answer)
{
    Console.WriteLine("Колличество четных элементов в массиве: "+ answer);
}
PrintAnswer(EvenCount(array));