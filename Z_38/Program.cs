// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76//


/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/


int[] GetRandomArray(int arrayLenght1, int start, int end)//создаёт массив
{
    int[] array = new int[arrayLenght1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)//заполняет массив рандомными числами
{
    System.Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
}

int maxFillarray(numbers[0])
{
    while (numbers[i] > maxFillarray)
    {
    maxFillarray = numbers[i];
    }   
}

int minFillarray(numbers[0])
{
    while (numbers[i] < minFillarray)
    {
    minFillarray = numbers[i];
    } 
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");

System.Console.WriteLine("Введи размер массива, минимальное и максимальное значение");
int arrayL = Convert.ToInt32(Console.ReadLine());//длина массива
int min = Convert.ToInt32(Console.ReadLine());//минимальное значение
int max = Convert.ToInt32(Console.ReadLine());//максимальное значение