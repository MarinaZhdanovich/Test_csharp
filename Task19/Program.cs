/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа. (Сгенерировать число: 85
Максимальная цифра в числе 85 = 8
85 = 85 / 10 = 8, 85 % 10 = 5)
*/
int RandomNum()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine($"Сгенерировать число: {num}");
    return num;
}

int MaxDigit(int number)
{
    int first = number / 10;
    int second = number % 10;
    if (first > second)
        return first;
    else
        return second;
}

int rand = RandomNum();
int maxDigit = MaxDigit(rand);
Console.WriteLine($"Максимальная цифра в числе {rand} = {maxDigit}");