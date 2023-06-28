﻿/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Копировать в лоб массивы нельзя
*/
int[] A = {3, 4, 5, 6};
Console.WriteLine(String.Join(" ", A));
int[] C = new int[A.Length];

for (int i = 0; i < C.Length; i++)
{
    C[i] = A[i];
}

Console.WriteLine(String.Join(" ", C)); // новый массив
A[2] = 10;
Console.WriteLine(String.Join(" ", A));
Console.WriteLine(String.Join(" ", C));
/*
int[C] = A; // та же ссылка на массив А
// если менять А, то изменится и С
*/
