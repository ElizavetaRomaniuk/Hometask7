// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Input m");
string example1 = Console.ReadLine();
int m = Convert.ToInt32(example1);
Console.WriteLine("Input n");
string example2 = Console.ReadLine();
int n = Convert.ToInt32(example2);

int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(-10, 11);
Console.Write(array[i, j] + " ");
}
}