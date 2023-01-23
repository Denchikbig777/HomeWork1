// Задача №2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

//a = 5; b = 7 -> max =7
//a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите число a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA>numberB)
{
    Console.WriteLine("Число a является большим числом, число b меньшим");
}
else
{
    Console.WriteLine("Число b является большим числом, число a меньшим");
}