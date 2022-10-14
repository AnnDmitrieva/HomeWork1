Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Вы ввели число 0.");
}
else
{
    if (number > 0)
     {
        int rem = number % 2;
        if (rem == 1)
        {
            Console.WriteLine("Вы ввели нечетное число.");
        }
        else
        {
            Console.WriteLine("Вы ввели четное число.");
        }
     }
    else
     {
        int rem = number % 2;
        if (rem == -1)
        {
            Console.WriteLine("Вы ввели нечетное число.");
        }
        else
        {
            Console.WriteLine("Вы ввели четное число.");
        }
     }
}
