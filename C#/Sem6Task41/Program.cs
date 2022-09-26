// # 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь. 

// Метод считывания данных пользователя
string[] ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);  
    // Считываем число, проверяем на NULL 
    // и разбиваем строку на массив строк
  string inputLine = Console.ReadLine() ?? "0";
  string[] array =  inputLine.Split(",");
    // Возвращаем значение
    return array;
}
// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}
// метод подсчета чисел больше 0
int Count(string[] array)
{
int result = 0; 
for (int i = 0; i< array.Length; i++)
{
if (int.Parse(array[i]) > 0) result++; 
}
return result;
}

string[] array = ReadData ("Input numbers with tail");

PrintResult($"Digit of numbers > 0 is {Count(array)}");