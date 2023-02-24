Console.Write("Imput a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current ++;
}