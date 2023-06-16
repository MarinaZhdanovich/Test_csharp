/* Напишите программу, которая принимает на вход координаты двух точек и 
находит растояние между ними в 2D пространстве.
A(3,6); B(2,1) -> 5,09
A(7,-5); B(1,-1) -> 7,21
*/

int GetInfo(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int xA = GetInfo("Введите x для A: ");
int yA = GetInfo("Введите y для A: ");
int xB = GetInfo("Введите x для B: ");
int yB = GetInfo("Введите y для B: ");

double Root( int xA, int yA, int xB, int yB)
{
    double resX = Math.Pow(xB - xA, 2);
    double resY = Math.Pow(yB - yA, 2);
    double result = Math.Sqrt(resX + resY);
    return result;
}

double distance = Root(xA, yA, xB, yB);
Console.WriteLine(Math.Round(distance, 2));


