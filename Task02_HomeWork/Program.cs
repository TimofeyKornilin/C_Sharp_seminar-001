// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Clear();
Console.WriteLine("         *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter firts number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (number1 == number2) Console.WriteLine("The numbers are equal");
else
{
    if (number1 > number2)
    {
        Console.WriteLine($"Maximum number is {number1}");
        Console.WriteLine($"Minimum number is {number2}");
    }
    else
    {
        Console.WriteLine($"Maximum number is {number2}");
        Console.WriteLine($"Minimum number is {number1}");
    }
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("          *** END program ***");
Console.WriteLine("");