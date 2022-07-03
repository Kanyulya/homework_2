// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите трехзначное число: ");
int num = Convert.ToInt16(Console.ReadLine());
int secondNum = (num / 10) % 10;
Console.WriteLine(secondNum);

// int something(int start, int finish) //высветить среднюю цифру из рандомного трехзначного числа
// {
//     int numberA = new Random().Next(start, finish);
//     Console.WriteLine(numberA);
//     int secondNumber = (numberA / 10) % 10;
//     return secondNumber;
// }
// int num = something(100, 999);
// Console.WriteLine(num);