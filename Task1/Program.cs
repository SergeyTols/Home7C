Console.Write("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

createArray(array);
WriteArray(array);

void createArray(double[,] array)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray (double[,] array)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            double number = Math.Round(array[i, j], 2);
            Console.Write(number + "  ");
        }
        Console.WriteLine();
    }
}