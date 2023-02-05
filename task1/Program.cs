/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите положительное трехзначное число");
string str = Console.ReadLine();
int a = Convert.ToInt32(str);

int b = a/10;
int result = b%10;
Console.WriteLine(result);