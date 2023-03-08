// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void GetAverageInMatrixColumns(int[,] matrix){
    for (int columns = 0; columns < matrix.GetLength(1); columns++){
        int preAverage = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++){
            preAverage += matrix[rows,columns];
            }
        int average = preAverage/matrix.GetLength(0);
        Console.WriteLine($"В колонке {columns} среднее значение -> {average}");
    }
}

int[,] matrix = CreateMatrix(6, 10, 10, 99);
PrintMatrix(matrix);
GetAverageInMatrixColumns(matrix);