using System.Diagnostics;

Console.Write("Введите количество строк: ");
int ROWS = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
        int COLS = int.Parse(Console.ReadLine());
        int[,] matrix = new int[ROWS, COLS];


        Random random = new Random();
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++)
            {
                matrix[i, j] = random.Next(100);
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();


        for (int j = 0; j < COLS; j++)
        {
            int[] column = new int[COLS];
            for (int i = 0; i < COLS; i++)
            {
                column[i] = matrix[i, j];
            }
            Array.Sort(column);
            for (int i = 0; i < COLS; i++)
            {
                matrix[i, j] = column[i];
            }
        }

        stopwatch.Stop();

        Console.WriteLine("Отсортированная матрица:");
        PrintMatrix(matrix);

        Console.WriteLine($"Время сортировки: {stopwatch.Elapsed}");    

static void PrintMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
