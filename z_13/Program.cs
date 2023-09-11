//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6 //

System.Console.WriteLine("Введите  число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2;
num2 = num;
if(num2>99){
while (num2>1000)
{
    num2=num2/10;
}
System.Console.WriteLine(num2%10);}
else{System.Console.WriteLine("Третьей цифры нет в числе " + num2);}
