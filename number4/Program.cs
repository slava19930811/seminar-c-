﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.Write("Введите первое число: ");
string A = Console.ReadLine()!;

Console.Write("Введите второе число: ");
string B = Console.ReadLine()!;

Console.Write("Введите третье число: ");
string C = Console.ReadLine()!;

int a = int.Parse(A);
int b = int.Parse(B);
int c = int.Parse(C);
int max = a;

if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine(max);