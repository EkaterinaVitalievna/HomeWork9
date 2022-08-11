// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void SumArrNumbers()
{
    Console.Write("Введите первое натуральное число: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе натуральное число: ");
    int N = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    if (M < N)
    {
        for (int count = M; count <= N; count++)
        {
            sum += +count;
        }
    }
    else {
        for (int count = N; count <= M; count++)
        {
            sum += +count;
        }
    }
     Console.Write($"Сумма числе от первого введённого числа до второго: {sum}");
}

SumArrNumbers();