/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

void palindrom(int number)
{
    int a = 0;
    int summa = 0;
    for (a = number; number != 0; number = number / 10)
    {
        int b = number % 10;
        summa = summa * 10 + b;
    }
    if (a == summa)
        Console.WriteLine($"Число {a} является палиндромом.");
    else
        Console.WriteLine($"Число {a} не является палиндромом");
}

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
{
    palindrom(number);
}
