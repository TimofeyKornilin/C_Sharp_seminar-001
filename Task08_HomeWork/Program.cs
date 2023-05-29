// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("         *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter natural number: ");
double number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");


if (number < 0) Console.WriteLine("Not correct entered number. Try again");
else
{
    if (number < 2) Console.WriteLine("No have even numbers in this row");
    else
    {
        double count = 1;
        while (count <= number)
            if (((count / 2) * 10) % 10 == 0)
            {
                Console.Write($"{count} ");
                count++;
            }
            else count++;
    }
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("         *** END program ***");
Console.WriteLine("");