Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponent (int num1, int num2)
{
    int result = 1;
    for (int i=1; i<=num2; i++)
    {
        result = num1*result;
    }
    return result;
}
if (b>0)
{
    int expo = Exponent (a, b);
    Console.WriteLine($"Число {a} в степени {b} ---> {expo}");
}
else
{
    Console.WriteLine("Введите вещественное число");
}