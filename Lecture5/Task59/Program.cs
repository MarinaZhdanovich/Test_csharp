/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Fibonachi(int num)
{
    int firstNum = 0;
    int secondNum = 1;
    int temp = 0;
    if (num == 1) Console.WriteLine(firstNum);
    else Console.Write($"{firstNum} {secondNum}");
    for (int i = 3; i <= num; i++)
    {
        temp = secondNum;
        secondNum = firstNum + secondNum; //обновляем значение
        firstNum = temp;
        Console.Write($" {secondNum}"); // впереди пробел

    }
}
int n = InputNum("Введите число: ");
Fibonachi(n);

/*Например 5

firstNum = 0  выводим // 1 итерация
secondNum = 1 выводим // 2 итерация

3 итерация
temp = 1
secondNum = 0 + 1 = 1  выводим
firstNum = 1

4 итерация
temp = 1
secondNum = 1 + 1 = 2 выводим
firstNum = 1

5 итерация
temp = 2
secondNum = 1 + 2 = 3 выводим
firstNum = 2

*/