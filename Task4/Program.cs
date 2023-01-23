// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44,5,78 -> 78
//22, 3, 9, -> 22

Console.Write("Введите число A:");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B:");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число C:");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;

if(numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.Write("max=" + max);