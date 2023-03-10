// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] FillRandomArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i =0;i<array.Length;i++)
    {
        array[i] = rnd.Next(100,1000);
    }
    return array;
}
int ValueOfEvenNumbers(int [] arr)
{
    int count = 0;
    for(int i =0;i<arr.Length;i++)
    {
        if(arr[i]%2==0) count+=1;
    }
    return count;
}
System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int []array = FillRandomArray(size);
System.Console.WriteLine($"[{string.Join(' ',array)}]");
System.Console.WriteLine($"Количество четных чисел в массиве: {ValueOfEvenNumbers(array)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] FillRandomArray (int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i =0;i<array.Length;i++)
    {
        array[i] = rnd.Next(-10,11);
    }
    return array;
}
int SumOddIndexNumbers(int [] arr)
{
    int sum = 0;
    for(int i =1;i<arr.Length;i+=2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int []array = FillRandomArray(size);
System.Console.WriteLine($"[{string.Join(' ',array)}]");
System.Console.WriteLine
($"Сумма чисел массива с нечетным индексом: {SumOddIndexNumbers(array)}");
*/

// Задача 38: Задайте массив вещественных чисел(тип double). 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

/*
double[] FillRandomDoubleArray (int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for(int i =0;i<array.Length;i++)
    {
        array[i] = rnd.Next(-100,100)+ Math.Round(rnd.NextDouble(),2);
    }
    return array;
}
double FindDiffMaxMin(double[] arr)
{
    double max =arr[0];
    double min =arr[0];
    for(int i =0;i<arr.Length-1;i++)
    {
        if(arr[i]>max) max = arr[i];
        else if(arr[i]<min) min = arr[i];
    }
    return max - min;
}
System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = FillRandomDoubleArray(size);
System.Console.WriteLine($"[{string.Join(' ',array)}]");
System.Console.WriteLine
($"Разница между максимальным и минимальным элементом массива: {FindDiffMaxMin(array)}");
*/