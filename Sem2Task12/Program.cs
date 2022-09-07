//========================================================================
// # Задача 12 Напишите программу, которая будет принимать на вход два  
// числа и выводить, является ли второе число кратным первому. Если второе
// число некратно первому, то программа выводит остаток от деления.
//========================================================================

{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();
    if (inputLineA != null && inputLineB != null)
    {
        int inputNumberA = int.Parse(inputLineA);
        int inputNumberB = int.Parse(inputLineB);
    
        Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
    }
}