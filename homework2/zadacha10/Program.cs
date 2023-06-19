/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());


int part1 = number / 10;
int part2 = part1 % 10;

if (part2 < 0)
{
    part2 = part2 * -1;
    Console.WriteLine(part2);
}
else
{
    Console.WriteLine(part2);
}
