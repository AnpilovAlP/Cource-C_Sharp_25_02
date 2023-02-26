//Задача 1: Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число
//большее, а какое меньшее.

string s_a = Console.ReadLine()!;
string s_b = Console.ReadLine()!;

int a = int.Parse(s_a);
int b = int.Parse(s_b);

if (a < b) Console.WriteLine(b);
if (b < a) Console.WriteLine(a);
