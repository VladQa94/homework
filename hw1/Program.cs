/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите два числа: ");
int numberA = new int();
int numberB = new int();
int max = 0;
int min = 0;
numberA = Convert.ToInt32(Console.ReadLine());
numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    max = numberA;
    min = numberB;
    Console.Write("max= ");
    Console.WriteLine(max);
    Console.Write("min= ");
    Console.WriteLine(min);
}
if (numberA < numberB)
{
    max = numberB;
    min = numberA;
    Console.Write("max= ");
    Console.WriteLine(max);
    Console.Write("min= ");
    Console.WriteLine(min);
}
if (numberA == numberB)
{
    Console.WriteLine("Числа равны!");
}