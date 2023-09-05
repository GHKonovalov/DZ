//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3//

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
}
else if (num1 > num2)
    Console.WriteLine($"Число {num1} больше числа {num2}");
else
{
    Console.WriteLine("Числа равны");
}    