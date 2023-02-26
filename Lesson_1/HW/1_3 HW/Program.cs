// Задача 4: Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все
//чётные числа от 1 до N.

string s_a = Console.ReadLine()!;

int a = int.Parse(s_a);


int b = Convert.ToInt32(a % 2 == 0);



while (b <= a)

{
    if (b % 2 == 0)
        Console.WriteLine(b);
    b++;
}