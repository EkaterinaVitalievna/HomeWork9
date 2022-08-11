// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ArrNumbers()
{
    Console.Write("Введите первое число: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int N = Convert.ToInt32(Console.ReadLine());

    Console.Write("Натуральные числа от M до N: ");

    if (M < N)
    {
        for (int count = M; count < N; count++)
        {
            Console.Write($"{M++} ");
        }
    }
    else
    {
        for (int count = N; count < M; count++)
        {
            Console.Write($"{N++} ");
        }
    }
}

ArrNumbers();