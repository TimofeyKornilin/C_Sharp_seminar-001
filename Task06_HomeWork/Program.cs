// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("         *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter integer number: ");
double number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (number % 2 == 0) Console.WriteLine($"Yes, the number {number} is even number");
//if (((number/2)*10) % 10 == 0) Console.WriteLine($"Yes, the number {number} is even number");
else Console.WriteLine($"No, the number {number} is not even number");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("          *** END program ***");
Console.WriteLine("");