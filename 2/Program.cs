﻿Console.Write("Ведите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max > number2)
{
    if (max > number3)
    {
        Console.WriteLine($"Максимальное число {max}");
    }
}

else
{
    max = number2;
    if (number2 > number3)
    {
       Console.WriteLine($"Максимальное число {max}"); 
    }
    else
    {
        max = number3;
        Console.WriteLine($"Максимальное число {max}");
    }
}

