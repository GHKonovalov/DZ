// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет//


Console.WriteLine("Enter number weeksday: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0 && num<6)
{
    Console.WriteLine("working day");
}
if (num>5 && num<8)

Console.WriteLine("weekend");

else if (num>7)
Console.WriteLine("there is no such day");