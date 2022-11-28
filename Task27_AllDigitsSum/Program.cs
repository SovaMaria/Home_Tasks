Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int AllDigitsSum (int num)
{
    int summa = 0;
    while (num > 0)
    {
        summa = summa + num % 10;
        num = num / 10;
    }
    return summa;
}
if (number<0) number = -number;
int SummaDigit = AllDigitsSum(number);
Console.WriteLine($"Сумма цифр числа {number} ---> {SummaDigit}");