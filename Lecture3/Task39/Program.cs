/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Factorial(int num)
{
    int count = 1;
    for (int i = 1; i <= num; i++) count *= i;
    return count;
}
int num = InputNum("Введите целое число: ");
int res = Factorial(num);
Console.WriteLine($"Факториал числа равен: {res}");