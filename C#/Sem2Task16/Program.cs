//===================================================================================
// #16 Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
//===================================================================================


//Получаем число
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

//Тест на квадрат
bool SqrTest(int firstNum, int secNum)
{
    if (firstNum == Math.Pow(secNum, 2))
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Выводим результат
void PrintData(int firstNum, int secNum)
{
    if (SqrTest(firstNum, secNum))
    {
        Console.WriteLine("Число " + firstNum + " является квадратом числа " + secNum);
    }
    else
    {
        Console.WriteLine("Число " + firstNum + " не является квадратом числа " + secNum);
    }
}

int num1 = ReadData("Введите число 1");
int num2 = ReadData("Введите число 2");
PrintData(num1, num2);
PrintData(num2, num1);