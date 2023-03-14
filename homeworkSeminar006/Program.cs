// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int [] FillArrayWithConsole(int size)
{
    int [] array = new int [size];
    for(int i =0;i<array.Length;i++)
    {
        System.Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }   
    return array;
}

void PrintValueOfPositiveNumbers(int [] arr)
{
    int count = 0;
for(int i =0;i<arr.Length;i++)
    {
        if(arr[i]>=0)
        {
            count+=1;
        }
    }  
     System.Console.WriteLine($"Количество чисел больше нуля: {count}");
}
System.Console.WriteLine("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = FillArrayWithConsole(size);
System.Console.WriteLine("Ваш массив: ");
System.Console.WriteLine($"[{string.Join(" ", array)}]");
PrintValueOfPositiveNumbers(array);
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void PrintPointOfCrossLines(double b1, double  k1 , double  b2, double k2)
{
    if(b1==b2 && k1==k2)
    {
    System.Console.WriteLine("Прямые совпадают");
    return;
    }
    else if(b1==b2 || k1==k2)
    {
    System.Console.WriteLine("Прямые параллельны");
    return;
    }
    double x = (b2-b1)/(k1-k2);
    double y = k2*x+b2;
    System.Console.WriteLine($"Координаты точки пересечения: x:{x} y:{y}");
}

System.Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

PrintPointOfCrossLines(b1,k1,b2,k2);
*/