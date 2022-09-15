//======================================================================
// # Задача 11 Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.
//======================================================================

System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(100, 1000);
Console.WriteLine("\nСгенерированное случайное число = " + number);

int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine(firstDigit * 10 + thirdDigit);