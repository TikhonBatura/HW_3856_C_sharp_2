// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Задача 10");
Console.WriteLine("********");
Console.WriteLine("Enter 3-digital number  ");
string? strNumber = Console.ReadLine();
int number = int.Parse(strNumber);
Console.WriteLine(" ");
Console.WriteLine(" ");
if((number>100) && (number<999)) 
{
    number = number / 10;
    number = number % 10;
    Console.Write ("Second ditigital in entered number is ");
    Console.WriteLine (number);
}
else
{
Console.WriteLine("Input incorrect number, plese try again.");
}
Console.WriteLine("********");
Console.WriteLine(" ");
Console.WriteLine(" ");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Задача 13");
Console.WriteLine("********");

Console.WriteLine("Let's play the game...");
Console.WriteLine("Enter number and I show you 3th digital of it");
Console.Write("Enter number ");

string? strNumber2 = Console.ReadLine();
int number2 = int.Parse(strNumber2);
int i = 1;
if(number2 < 0) 
{
    number2 = number2 * (-1); 
    
}
Console.WriteLine(" ");
Console.WriteLine(" ");
if (number2 > 100)
    {
    while(number2/i > 999)
        {
            i = i*10;
        }
    number2 = number2 / i;
    number2 = number2 % 10;
    Console.WriteLine ($"The 3th digital in entered number is {number2}");
    }

else 
    {
    Console.WriteLine ($"input number have less than three digital, plese try again");
    }

Console.WriteLine("********");
Console.WriteLine(" ");
Console.WriteLine(" ");


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

