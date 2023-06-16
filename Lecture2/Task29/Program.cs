/* Напишите программу, которая принимает на вход число N и выдает 
таблицу квадратов чисел от 1 до N
*/

int GetInfo(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int N = GetInfo("Введите число: ");
for (int i = 1; i <= N ; i++) // i = 1 по условию
{
    Console.Write($"{Math.Pow(i, 2)}");
    if (i < N )  
        Console.Write(", ");
    else
        Console.Write(".");
}
