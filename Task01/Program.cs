// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("");
Console.WriteLine("*** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Square for {number} = {square}");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("*** END program ***");
Console.WriteLine("");