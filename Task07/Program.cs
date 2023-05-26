// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Clear();
Console.WriteLine("");
Console.WriteLine("         *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter your three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 10; 
Console.WriteLine($"Last digit for your number is {lastDigit}");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("          *** END program ***");
Console.WriteLine("");