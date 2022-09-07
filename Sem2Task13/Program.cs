//=======================================================================
// # Задача 13 Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
//=======================================================================

Console.Write("Введите  число = ");
string? userNumber = Console.ReadLine();

if (userNumber != null)
{
     if (userNumber.Length >= 3)
     {
         char[] arrayNumber = userNumber.ToCharArray();
         Console.WriteLine("Третья цифра числа = " + arrayNumber[2]);
     }
     else
     {
         Console.WriteLine("Третьей цифры нет");
     }
}