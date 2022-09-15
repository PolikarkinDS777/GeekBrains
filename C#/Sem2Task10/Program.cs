//=======================================================================
// # Задача 10 Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
//=======================================================================

int userN = 0;
string userNum = "";
bool flag = false;

void ReadData()
{
    Console.Write("Введите трёхзначное число = ");
    string? inputNumber = Console.ReadLine();
    if (inputNumber != null)
    {
        if (inputNumber.Length == 3)
        {
            userNum = inputNumber;
            userN = int.Parse(inputNumber);
            flag = true;
        }
        else
        {
            Console.WriteLine("\nЧисло не трёхзначное");
        }

    }
}

void Decision()
{
    if(flag)
    {
        char[] arrayNum = userNum.ToCharArray();
        Console.WriteLine("Вторая цифра числа = " + arrayNum[1]);
    }
}
ReadData();
Decision();