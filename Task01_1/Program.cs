//  Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();
Console.WriteLine("");
Console.WriteLine("         *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2)
{
    Console.WriteLine($"Yes, {number1} is a square for {number2}.");
}
else 
{
    Console.WriteLine($"No, {number1} is NOT a square for {number2}.");
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("         *** END program ***");
Console.WriteLine("");