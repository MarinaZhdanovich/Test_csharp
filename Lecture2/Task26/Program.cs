/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int GetInfo(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string GetRange(int number)
{
    if (number == 1) return "x > 0, y > 0.";
    else if (number == 2) return "x < 0, y > 0.";
    else if (number == 3) return "x < 0, y < 0.";
    else if (number == 4) return "x > 0, y < 0.";
    else return "Такой четверти нет.";
}

int result = GetInfo("Введите номер четверти: ");
string final = GetRange(result);
Console.WriteLine(final);