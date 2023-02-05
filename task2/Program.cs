/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите положительное трехзначное число");
string str = Console.ReadLine();
int a = Convert.ToInt32(str);

if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
    while (a > 999)
    {
        a = a/10;
    }
    int b = a%10;
    Console.WriteLine(b);
}
