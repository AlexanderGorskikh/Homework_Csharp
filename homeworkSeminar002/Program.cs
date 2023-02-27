/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/
/*
Console.Write("Input a third-digit number ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumeral(int threeDigitNumber)
{
    int lessOnes = threeDigitNumber/10;
    return lessOnes%10;
}
Console.Write($"Second numeral of your number is: {SecondNumeral(threeDigitNumber)}");
*/

/*Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/
/*
Console.Write("Imput a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int ThirdNum(int num)
{
    while(num>1000) 
    {
        num = num/10;
    }
    return num%10;
}
if(num<100) Console.WriteLine("Loss of third numeral");
else Console.WriteLine(ThirdNum(num));
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Imput day's number of the week: ");
int numDay = Convert.ToInt32(Console.ReadLine());
bool Weekend(int day)
{
    if(day==6 ^ day == 7) return true;
    return false;
}
if(Weekend(numDay)==true) Console.WriteLine("Yes, it's weekend");
else Console.WriteLine("No, it's not weekend");
*/
