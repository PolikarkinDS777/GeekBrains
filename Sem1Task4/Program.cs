//===========================================================================
// # 4 Напишите программу, которая на вход принимает три числа и 
// выдает максимальное из этих чисел
//===========================================================================

Console.Write("Введите число A:");
string? inputLineA = Console.ReadLine();
Console.Write("Введите число B:");
string? inputLineB = Console.ReadLine();
Console.Write("Введите число C:");
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int A = int.Parse(inputLineA);
    int B = int.Parse(inputLineB);
    int C = int.Parse(inputLineC);
    if (A > B)
    {
        if(A > C)
        {
            Console.Write("A - максимальное число");
        }
        else
        {
            Console.Write("C - максимальное число");
        }
    }
    else
    {
        if(B > C)
        {
            Console.Write("B - максимальное число");
        }
        else
        {
            Console.Write("C - максимальное число");
        }
    }
}