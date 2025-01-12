﻿// #64. Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод вывода в консоль строки
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Выдает требуемые числа
string LineGenRec(int numN)
{
    //Точка остановки
    if (numN == 0)
        return "";
    string outLine = numN + " " + LineGenRec(numN - 1);
    return outLine;
}

int numN = ReadData("Введите число N: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);