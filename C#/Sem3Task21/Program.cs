﻿//===================================================================================
// #21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве
//===================================================================================

//общение с пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
double Calculation(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    res = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
    return res;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}

Console.WriteLine("Введите координаты первого отрезка:");
int x1 = ReadData("x = ");
int y1 = ReadData("y = ");
int z1 = ReadData("z = ");
Console.WriteLine("Введите координаты второго отрезка:");
int x2 = ReadData("x = ");
int y2 = ReadData("y = ");
int z2 = ReadData("z = ");

double res = Calculation(x1, y1, z1, x2, y2, z2);
PrintResult("Расстояние между точками:" + Math.Round(res, 2));