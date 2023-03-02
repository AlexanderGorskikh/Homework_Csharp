/*
double num = 5;
double res = Math.Pow(num,2);            // возведение в степень
Console.WriteLine(res);
*/

/*
double result = 5;
result = Math.Sqrt(num,2);            // вычисление квадратного корня
Console.WriteLine(res);
*/

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
*/
/*
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num/10000==num%10 && (num/1000)%10 == (num%100)/10)
{
    Console.WriteLine("Введенное число является полиндромом");
}
else Console.WriteLine("Введенное число не является полиндромом");
*/
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
*/
/*
void FillCoordinate(int[] array)
{
    array[0] = new Random().Next(-10,10);
    array[1] = new Random().Next(-10,10);
    array[2] = new Random().Next(-10,10);
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2, int x3, int y3, int z3)
{
    double sumPows = Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2);
    return Math.Sqrt(sumPows);
}

int [] firstPoint = new int[3];
FillCoordinate(firstPoint);
int [] secondPoint = new int[3];
FillCoordinate(secondPoint);
int [] thirdPoint = new int[3];
FillCoordinate(thirdPoint);

double distance = Distance(firstPoint[0],firstPoint[1],
firstPoint[2],secondPoint[0],secondPoint[1],secondPoint[2],
thirdPoint[0],thirdPoint[1],thirdPoint[2]);
Console.WriteLine(distance);
*/
/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void  Square(int num)
{
    for(int current = 1;current<=num;current++)
    {
        Console.Write(current*current + " ");
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Square(number);
*/