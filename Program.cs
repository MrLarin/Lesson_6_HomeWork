﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2-> 2
1, -7, 567, 89, 223-> 3 */
/*
int count = 0;
int M;
for (int i = 0; i < 5; i++)
{
    Console.Write("Введите число: ");
    int.TryParse(Console.ReadLine()!, out M);
    if (M > 0)
        count++;
}
Console.Write($"{count}");
*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int b1, b2, k1, k2;
Console.Write("Введите Значение b1: ");
int.TryParse(Console.ReadLine(), out b1);
Console.Write("Введите Второе число b2: ");
int.TryParse(Console.ReadLine(), out b2);
Console.Write("Введите Третье число k1: ");
int.TryParse(Console.ReadLine(), out k1);
Console.Write("Введите Третье число k2: ");
int.TryParse(Console.ReadLine(), out k2);

double x = (double)(b2 - b1) / (k1 - k2);
double y = (double)k1 * x + b1;

Console.Write($"Координаты персечения данных прямых: ({x}; {y}) ");



