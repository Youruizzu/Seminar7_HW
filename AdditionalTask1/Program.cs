// Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, 
// сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.

// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет

// 2 4 7 2
// 4 3 5 3
// 2 1 6 2 -> да

Console.Clear();

int[,] CreateMatrix(int rows, int columns, int min, int max){
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            matrix[i,j] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for (int rows = 0; rows < matrix.GetLength(0); rows++){
        for (int columns = 0; columns < matrix.GetLength(1); columns++){
            Console.Write($"{matrix[rows, columns]} ");
            }
        Console.WriteLine();
    }
}

void IsColumnsSummHighterThanCornersSumm(int[,] matrix){
    int corners = matrix[0,0] 
                + matrix[0, matrix.GetLength(1)-1] 
                + matrix[matrix.GetLength(0)-1, 0] 
                + matrix[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int columns = 0; columns < matrix.GetLength(1); columns++){
        int summ = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++){
            summ += matrix[rows,columns];
            }
        if(summ > corners) Console.WriteLine($"Сумма колонки {columns} ({summ}) больше суммы углов ({corners})");
    }
}

int[,] matrix = CreateMatrix(4, 4, 10, 99);
PrintMatrix(matrix);
IsColumnsSummHighterThanCornersSumm(matrix);