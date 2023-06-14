// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number1 = int.Parse (Console.ReadLine());
if ((number1>=100)&&(number1<1000))
{
    number1 = number1/ 10 % 10;
    Console.WriteLine(number1);
}
else 
{
    Console.WriteLine("Число слшиком маленькое или слишком большое");
}