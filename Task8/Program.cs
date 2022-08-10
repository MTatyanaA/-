// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
 Console.WriteLine("Чётные числа от 1 до N: ");
while (a <= N)
{
    int b = a % 2; 
    if (b == 0)
    Console.WriteLine(a);
    a=a+1;
}