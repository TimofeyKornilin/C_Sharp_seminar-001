// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.WriteLine("");
Console.WriteLine("         *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = -number;
Console.WriteLine(" ");

while (number2 <= number)
{
    Console.Write($"{number2} ");
    number2 = number2 + 1;
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("          *** END program ***");
Console.WriteLine("");