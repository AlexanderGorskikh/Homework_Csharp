// Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
/*
int CutNumber(int num)
{                                                     
    int hundreds = num / 100;
    int ones = num % 10;

    int result = hundreds * 10 + ones;
    return result;
}
int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/
// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно a и b.
/*
bool IsDivided(int num, int firstDevider, int SecondDevider)
{
    return number % firstDevider == 0 && SecondDevider == 0;
    
    if(number % firstDevider == 0 && SecondDevider == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Imput a number for checking: ");
int num = Convert/ToInt32(Console/ReadLine());
Console.Write("Imput a first divider: ");
int div1 = Convert/ToInt32(Console/ReadLine());
Console.Write("Imput a second divider: ");
int div2 = Convert/ToInt32(Console/ReadLine());
*/
// task 3
/*
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
*/
/*
int num = new Random().Next(10,100);
int MaxNum(int maxNum)
{
    int ten = maxNum/10;
    int one = maxNum%10;
    if(ten>one)
        return ten;
    else
        return one;
}
Console.WriteLine($"Рандомное число это: {num} наибольная цифра это: {MaxNum(num)}");
*/
// task 4
/*
Напишите программу, 
которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
*/
/*
bool IsQuad(int first, int second)
{
    if(first == second*second || second == first*first)
    {
        return true;
    }
    else return false;
} 
Console.Write("Input a first number for checking ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsQuad(num1,num2));
*/