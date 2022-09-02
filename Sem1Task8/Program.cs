//===========================================================================
// # 8 Напишите программу, которая принимает на вход число (N),
// а на выходе показывает все четные числа от 1 до N.
//===========================================================================

string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 2)
    {
        Console.WriteLine("Введите число больше 1");
    }
    int startIndex = 2;
    while (startIndex <= inputNumber - 2)
    {
        Console.Write(startIndex + ", ");
        startIndex += 2;
    }
    if (startIndex % 2 == 0)
    {
        Console.Write(startIndex);
    }
}