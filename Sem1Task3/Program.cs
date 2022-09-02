//========================================================================
// # 3 Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
//========================================================================
string? inputLine = Console.ReadLine();

if(inputLine != null)
{

    int inputWeekday = int.Parse(inputLine);

    string [] weekday = new string[7];
    weekday[0] = "Понедельник";
    weekday[1] = "Вторник";
    weekday[2] = "Среда";
    weekday[3] = "Четверг";
    weekday[4] = "Пятница";
    weekday[5] = "Суббота";
    weekday[6] = "Воскресенье";

if(inputWeekday > 7 || inputWeekday < 1)
{
    Console.WriteLine("Такого дня нет");
}
    Console.WriteLine(weekday[inputWeekday-1]);
}