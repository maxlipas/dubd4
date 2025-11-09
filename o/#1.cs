//Лабораторная работа №4. Массивы.
//Одномерные массивы
//средний уровень 26 вариант
try
{
    double[] mas1 = new double[12];
    Random r = new Random();
    Console.WriteLine($"массив 1:");
    for (int i = 0; i < mas1.Length; i++)
    {
        mas1[i] = r.NextDouble() *100;
        Console.Write($"{mas1[i]:F0} ");
    }
    Console.WriteLine();
    double[] mas2 = new double[12];
    Console.WriteLine($"массив 2:");
    for (int i = 0; i < mas2.Length; i++)
    {
        mas2[i] = r.NextDouble() * 100;
        Console.Write($"{mas2[i]:F0} ");
    }
    Console.WriteLine();
    Console.WriteLine($"массив с нулями:");
    for (int k= 0; k < mas1.Length; k++)
    {
        for (int i = 0; i < mas2.Length; i++)
            if (mas1[k] == mas2[i])
        {
            mas1[k] = 0;
        }
        Console.Write($"{mas1[k]:F0} ");
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}