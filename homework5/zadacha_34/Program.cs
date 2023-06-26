/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.*/

void findEven(int number1, int number2, int number3)
{
    int[] array = new int[number3 + 1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(number1, number2 + 1);
        Console.Write(array[i] + " ");
    }
    
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine( $"Количество четных элементов массива равно {count}");
}

Console.WriteLine("Введите минимальное трехзначное значение элемента массива: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное трехзначное значение элемента массива: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество элементов в массиве:");
int number3 = int.Parse(Console.ReadLine());
if (number1 < 100 || number1 > 999 || number2 < 100 || number2 > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}
else
{
    findEven(number1, number2, number3);
}