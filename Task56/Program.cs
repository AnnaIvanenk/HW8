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

int [,] matrix = CreateArray(10, 10);
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();

// суммируем элементы построчно
int min = 0;
int line = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
                sum += matrix[i, j];
    }
    System.Console.WriteLine($"{sum}");


// ищем строку с наименьшей суммой
min = sum;
if (sum < min)
{
    min = sum;
    line ++;
  }  
}
System.Console.WriteLine();
System.Console.WriteLine($"{min}");