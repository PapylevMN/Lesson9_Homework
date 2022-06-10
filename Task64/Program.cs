void ShowNumbersNeg(int num)
{
    if(num == 2) return;
    Console.Write($"{num} ");
    ShowNumbersNeg(num+1);
}

void ShowNumbersPos(int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    ShowNumbersPos(num-1);
}

Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());
if (n>=0) ShowNumbersPos(n);
else ShowNumbersNeg(n);
