// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

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

void GetNumberFromMatrix(int[,] matrix, int row, int column){
    try{
        Console.WriteLine($"{row}, {column} -> {matrix[row,column]}");
    }
    catch(IndexOutOfRangeException){
        Console.WriteLine($"{row}, {column} -> Элемента под данными индексами нет в массиве");
    }
}

int[,] matrix = CreateMatrix(3, 4, 10, 99);

PrintMatrix(matrix);
GetNumberFromMatrix(matrix, 4, 4);
GetNumberFromMatrix(matrix, 2, 3);

