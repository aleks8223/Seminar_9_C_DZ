// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return GetAkkerman(m - 1, 1);
    return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}
Console.WriteLine($"M = {m}; N = {n} -> A(m,n) = {GetAkkerman(m, n)}");
