//Лабораторная работа №4. Массивы.
//Двумерные массивы
//высокий уровень 18 вариант
try
{
    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите m: ");
    int m = int.Parse(Console.ReadLine());
    int[,] A = new int[n, m];
    int current = 0;
    for (int start = 0; start < n + m - 1; start++)
    {
        if (start < n)
        {
            int i = start;
            int j = 0;
            while (i >= 0 && j < m)
            {
                A[i, j] = current++;
                i--;    
                j++;
            }
        }
        else
        {
            int i = n - 1;
            int j = start - n + 1;
            while (i >= 0 && j < m)
            {
                A[i, j] = current++;
                i--;
                j++;
            }
        }
    }
    Console.WriteLine("массив:");
    Console.WriteLine("");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{A[i, j]} ");
        }
        Console.WriteLine();
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}