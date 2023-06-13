/*
Напишите программу, которая выводит случайное трехзначное число и 
удаляет вторую цифру этого числа.
*/
// 123 -> 13
// 123 % 10 = 3 - последняя
// 123 /100 -1 первая
// 10 *1 + 3 = 13

int RandomNum()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"Сгенерировать число: {num}");
    return num;
}

int DelSecondDigit(int numb)
{
    int first = numb / 100;
    int second = numb % 10;
    int twoDigits = first * 10 + second;
    return twoDigits;
}


int number = RandomNum();
int result = DelSecondDigit(number);
Console.WriteLine($"Получилось: {result}");