//======================================================================
// # Задача 9 Напишите программу, которая выводит случайные числа из 
// отрезка [10, 100] и показывает наибольшую цифру этого числа.
//======================================================================


{
    Console.WriteLine("\nВариант 2 (тернарный оператор)");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine("\nСгенерированное случайное число = " + number);

    int firstDigit = number/10;
    Console.WriteLine("\nfirstDigit = " + firstDigit);
    int secondDigit = number%10;
    Console.WriteLine("secondDigit = " + secondDigit);
    
    Console.Write("\nНаибольшая цифра = ");
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}
