//=======================================================================
// # Задача 15 Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//=======================================================================

var dayWeek = new Dictionary<int, string>()
{
    {1, "Понедельник будний"},
    {2, "Вторник будний"},
    {3, "Среда будний"},
    {4, "Четверг будний"},
    {5, "Пятница будний"},
    {6, "Суббота выходной"},
    {7, "Воскресенье выходной"}
};
int inputNum = 0;
string result = "";

void ReadData()
{
    Console.Write("Введите число дня недели = ");
    string? inputNumber = Console.ReadLine();
    if (inputNumber != null)
    {
        inputNum = int.Parse(inputNumber);
    }
}

void CalculateData()
{
    result = (inputNum >= 1 && inputNum <= 7) ? dayWeek[inputNum] : "Такого дня недели нет.";
}

void PrintDate()
{
    Console.WriteLine("день недели - " + result);
}
ReadData();
CalculateData();
PrintDate();