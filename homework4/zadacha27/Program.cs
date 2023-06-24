// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void summa(int number)
{
    int index = number;
    int summ = 0;
    while (index > 0)
    {
        summ = summ + (index % 10);
        index = index / 10;
    }
    Console.WriteLine($"Сумма цифр числа {number} равна {summ}");
}
Console.WriteLine("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));
summa(number);