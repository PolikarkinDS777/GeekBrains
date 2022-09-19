// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int ReadData(string line)
{
     Console.WriteLine(line);
     int number = int.Parse(Console.ReadLine() ?? "0");
     return number;
}

void PrintResult(string line)
{
     Console.WriteLine(line);
}

int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
   Random ren = new Random();
   for (int i = 0; i < arrLength; i++)
    {
         array[i] = ren.Next(start, stop + 1);
    }
   return array;
}

void PrintArray(int[] arr)
{
     Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
         Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

bool ChekNumInArr(int[] arr, int num) 
{
   for (int i = 0; i < arr.Length; i++) 
     {
        if (arr[i] == num)
      {
        return true;
      }
    }
   return false;
}
int arrLength = ReadData("Введите длинну массива: ");
int start = ReadData("Введите минимальное значение: ");
int stop = ReadData("Введите максимальное значение: ");
int[] arr = GenArray(arrLength, start, stop); 
PrintArray(arr); 
int num = ReadData("Введите искомое значение: ");
PrintResult (num + "->  " + ChekNumInArr (arr,num)); 
