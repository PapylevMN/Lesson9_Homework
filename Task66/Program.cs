void ShowSum(int sum, int numM, int numN)
{
    if (numM == numN+1) 
    {
        Console.WriteLine($"Сумма натуральных чисел в заданном промежутке = {sum}");
        return;
    }
    sum = sum + numM;
    numM = numM + 1;
    ShowSum(sum, numM, numN);
}

Console.WriteLine("Задайте первое число : ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второе число : ");
int n = int.Parse(Console.ReadLine());
ShowSum(0, m, n);

