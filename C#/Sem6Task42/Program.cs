// #42 Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
 
// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

int numb = ReadData("Введите число: ");
string numbBin = Convert.ToString(numb, 2);

Console.WriteLine($"Число {numb} в двоичной системе: {numbBin}");
 numbBin = Convert.ToString(numb, 8);

Console.WriteLine($"Число {numb} в восьмеричная системе: {numbBin}");
 numbBin = Convert.ToString(numb, 16);

Console.WriteLine($"Число {numb} в шестнадцатеричная системе: {numbBin}");