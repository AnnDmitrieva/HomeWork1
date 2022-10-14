Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int rem = 2;

if (number <= 1)
{
    Console.WriteLine("ОШИБКА!Введите число > 1.");
}

else
{
    while (rem <= number)
    {
        Console.WriteLine($"{rem}");
        rem = rem + 2;
    }
}