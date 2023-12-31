﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


Console.Write("Enter number for start: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter number for end: ");
int end = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"M = {start}; N = {end} -> {SortNumbers(start, end)}");

string SortNumbers(int start, int end)
{
  if (end == start)
  {
    return end.ToString();
  }
  string result = SortNumbers(start + 1, end) + ", " + start.ToString();
  return result;
}
