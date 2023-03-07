// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
/*
int Sum(int A)
{
    int sum = 0;
    for(int i = 1; i<=A;i++)
    {
        sum+=i;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"Сумма от 1 до {number} = {sum}");
*/
/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*

int Counting(int number)
{
    int count = 0;
    while(number > 0)
    {
        number/=10;
        count++;
    }
    return count;
}
Console.Write("Imput number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = Counting(number);
Console.WriteLine($"Цифр в нашем числе {number} = {count}");
*/

/*
Задача 28: Напишите программу, которая принимает 
на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/
/*
int Incr(int A)
{
    int inc = 1;
    for(int i = 1; i<=A;i++)
    {
        inc*=i;
    }
    return inc;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int inc = Incr(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {inc}");
*/
/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
/*
string str = Console.ReadLine();
if(int.TryParse(str,out int number))
{
    if(number<0) // str.Contains("-")
    {
    Console.WriteLine($"Цифр в нашем числе {number} = {str.Length - 1}");
    }
    else
    {
    Console.WriteLine($"Цифр в нашем числе {number} = {str.Length}");
    }
}
else
{
    System.Console.WriteLine("Error");
}
*/

int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();   // Создаем объект класса, чтобы каждый раз не вызывать его в цикле for
    for(int i = 0;i<arr.Length;i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}

System.Console.WriteLine("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"{string.Join(",",array)}");