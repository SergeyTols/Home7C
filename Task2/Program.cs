// на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента.
// я тоже понял это так:

Console.Write("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

createArray(array);
WriteArray(array);
positionElement(array);

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

void positionElement(int[,] array)
{
    Console.WriteLine("Введите позиции элемента: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
        if(x <= m && y <= n &&
            x > 0 && y > 0)
        {
            Console.Write("Значение элемента: " + array[x - 1, y - 1]);
        }
        else
        {
            Console.Write("такого элемента в массиве нет");
        }
}