/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int numStart = 1;

while (numStart <= num)
{
    if (numStart % 2 == 0)
        Console.Write($"{numStart}, ");
        numStart ++;
}
