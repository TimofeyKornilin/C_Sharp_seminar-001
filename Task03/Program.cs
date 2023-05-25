// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.WriteLine("");
Console.WriteLine("         *** Start program ***");
Console.WriteLine("");
Console.WriteLine("");

Console.Write("Enter number of week day from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)  Console.WriteLine("Week day is Monday");
else if (number == 2)  Console.WriteLine("Week day is Tuesday");
     else if (number == 3)  Console.WriteLine("Week day is Wednesday");
          else if (number == 4)  Console.WriteLine("Week day is Thursday");
               else if (number == 5)  Console.WriteLine("Week day is Friday");
                    else if (number == 6)  Console.WriteLine("Week day is Saturday");
                         else if (number == 7)  Console.WriteLine("Week day is Sunday");
                              else  Console.WriteLine("Number is not from range from 1 to 7");
                              
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("         *** END program ***");
Console.WriteLine("");