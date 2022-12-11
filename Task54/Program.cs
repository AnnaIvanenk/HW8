// Создание
int[,] CreateArray(int row, int column)
{
    return new int[row, column];
}

// Заполнение
void FillArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(0, 20);
        }
    }
}

// Печать

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            System.Console.Write($"{array[row, column],4}");
        }
        System.Console.WriteLine();
    }
}

// Клиентский код

int rows = 10;
int columns = 10;
int[,] matrix = CreateArray(rows, columns);
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
// Упорядочиваем элементы строки по убыванию


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] < matrix[i, k + 1]) 
            {
                int temp = 0;
                temp = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = temp;
            }
        }
    }
}

PrintArray(matrix);