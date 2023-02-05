/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7");
string numberStrA = Console.ReadLine();
int numberA = Convert.ToInt32(numberStrA);
if (numberA < 6 && numberA > 0)
{
    Console.WriteLine("нет, сегодня не выходной");
}
else if (numberA > 5 && numberA < 8)
{
    Console.WriteLine("да, сегодня выходной");
}
else
{
    Console.WriteLine("Ввели неверное число");
}
