﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = int.Parse (Console.ReadLine());
if (number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{ if ((number<1000)&&(number>99))
{
    number = number % 10;
    Console.WriteLine(number);
}
else {
    while (number>999){
    number = number/10;
}
Console.WriteLine(number%10);
}}

    