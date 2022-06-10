int AccFunc(int m, int n)
{
    if (m == 0) return (n + 1);
    else if ((m > 0) && (n == 0)) return AccFunc(m - 1, 1);
    else if ((m > 0) && (n > 0)) 
    {
        n = AccFunc(m, n - 1);
        return AccFunc(m - 1, n);
    }
    return 0;
}

Console.Clear();
Console.WriteLine("Введите параметры функции Аккермана:");
Console.Write("m = ");
int a = int.Parse(Console.ReadLine());
Console.Write("n = ");
int b = int.Parse(Console.ReadLine());
int res = AccFunc(a, b);
if (res==0) Console.WriteLine("Исходные данные не корректны");
else Console.WriteLine($"Результат = {res}");


