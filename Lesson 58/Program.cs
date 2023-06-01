Console.WriteLine("Введите параметры для матрицы A");
var AA = MatrixParams();
Console.WriteLine("Введите параметры для матрицы B");
var BB = MatrixParams();
Console.WriteLine("матрица А");
WriteArray(AA);
Console.WriteLine($"\nматрица B");
WriteArray(BB);
if (AA.GetLength(0) != BB.GetLength(1))
{
    Console.WriteLine("Матрицы невозможно перемножить");
    return;
}
var c = Multiplication(AA, BB);
Console.WriteLine($"\nРезультат умножения");
WriteArray(c);
int[,] MatrixParams()
{
    Console.WriteLine("rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("min = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("max = ");
    int max = Convert.ToInt32(Console.ReadLine()); //вводим данные

    return CreatingArray(rows, columns, min, max);
}

int[,] CreatingArray(int rows, int columns, int min, int max)
{
    var array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
int[,] Multiplication(int[,] a, int[,] b)
{

    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}