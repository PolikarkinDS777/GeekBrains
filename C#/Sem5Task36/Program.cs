// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
int EvenSumPosition(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
int[] array = FillArray(11, 0, 100);
Print1DArray(array);
EvenSumPosition(array);
void PrintAnswer(int answer)
{
    Console.WriteLine("Сумма элементов на нечетной позиции равна: " + answer);
}
PrintAnswer(EvenSumPosition(array));

int[] array = FillArray (10,-20,100);
Print1DArray (array);
int sumArray = EvenSumPozition (array); 
PrintData ("Сумма нечетных элементов: " + sumArray);
