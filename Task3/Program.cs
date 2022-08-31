Console.Write("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

createArray(array);
WriteArray(array);


void createArray(int[,] array)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void WriteArray(int[,] array)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            int number = array[i, j];
            Console.Write(number + "  ");
        }
        Console.WriteLine();
    }
}


Console.Write("Cреднее арифметическое столбцов: ");
for (int j = 0; j < n; j++)
{
    double average = 0;
        for (int i = 0; i < m; i++)
        {
            average += array[i, j];
        }
    average = Math.Round(average / m, 1);
    Console.Write(average + "  ");
}
