﻿// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Clear();
Console.WriteLine("         *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter firts number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (number1 == number2 && number1 == number3) Console.WriteLine("Those numbers are equal");
else
{
    if (number1 > number2)
      if (number1 > number3) Console.WriteLine($"Maximum number is {number1}");
      else Console.WriteLine($"Maximum number is {number3}");
    else if (number2 > number3) Console.WriteLine($"Maximum number is {number2}");
         else Console.WriteLine($"Maximum number is {number3}");
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("          *** END program ***");
Console.WriteLine("");