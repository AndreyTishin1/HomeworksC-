//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");

int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:");

int number2 = int.Parse(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"Число {number1} больше чем {number2}");
}
else if(number1 < number2)
{
    Console.WriteLine($"число {number1} меньше чем {number2}");
}
else
{
Console.WriteLine($"Число {number1} равно числу {number2}");
}
