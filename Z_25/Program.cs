//*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

Console.Write("введите число : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int step = A;

for (int i = 1; i < B; i++)
{
step = step * A;
}
Console.WriteLine("A в степени B равно: " + step);
