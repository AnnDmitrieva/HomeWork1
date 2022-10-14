Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Максимальное число {number1}");
    Console.WriteLine($"Миниимальное число {number2}");
}

if (number1 < number2)
{
    Console.WriteLine($"Максимальное число {number2}");
    Console.WriteLine($"Миниимальное число {number1}");
}

if (number1 == number2)
{
    Console.WriteLine("Числа равны.");
}