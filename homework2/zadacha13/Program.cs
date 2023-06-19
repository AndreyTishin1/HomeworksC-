﻿/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра числа: {number}");
}