/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
double Rank(int A, int B)
{
    double result = Math.Pow(A,B);
    return result;
}
System.Console.Write("Input number: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Imput degree of number: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"The result of exponentiation is: {Rank(A,B)}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int SumNumeral(int number)
{
    int sum = 0;
    while(number%10>0)
    {
        sum = number%10 + sum;
        number/=10;
    }
    return sum;
}
System.Console.Write("Input number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine($"Result is: {SumNumeral(number)}");
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
int[] FillArray (int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i = 0;i<array.Length;i++)
    {
        array[i] = random.Next(-20,20);
    }
    return array;
}
System.Console.WriteLine("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"[{string.Join(" ",array)}]");
*/