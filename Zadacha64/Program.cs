// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

string GetAllNaturalNTo1(int n, int i)
{
    if (n == i) return n.ToString();
    return (n + " " + GetAllNaturalNTo1(n - 1, i));
}
Console.WriteLine($"{GetAllNaturalNTo1(N, 1)}");