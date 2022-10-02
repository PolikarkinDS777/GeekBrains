﻿// #67. Напишите программу, которая на вход будет принимать число N
// и возвращать сумму его цифр.

// чтение данных из сонсоли
int ReadData(string line)
{
    Console.Clear();
    //Выводим сообщение 
    Console.WriteLine("{0}: ", line);
    string inputLine = Console.ReadLine() ?? "";
    return int.Parse(inputLine);
}

// возвращает сумму цифр числа N
int RecSumDigit(int numN)
{
    return numN == 0 ? 0 : numN % 10 + RecSumDigit(numN / 10);
}

// Вывод в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}

PrintResult(RecSumDigit(ReadData("Введите число")));