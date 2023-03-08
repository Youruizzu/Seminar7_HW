// Вывести первые n строк треугольника Паскаля. 
// Реализовать вывод в виде равнобедренного треугольника.
// N = 7 -> https://ibb.co/yWPZbG7

int Prompt(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

float factorial(int n){
    float factorial = 1;
    for (int i = 1; i <= n; i++){
        factorial *= i;
    }
    return factorial;
}
void MakePascalTriangle(int layers){
    for (int i = 0; i < layers; i++){
        for (int spaces = 0; spaces <= (layers - i); spaces++){
            Console.Write(" ");
        }
        for (int c = 0; c <= i; c++){
            Console.Write(" "); 
            Console.Write(Math.Round(factorial(i) / (factorial(c) * factorial(i - c)), 0)); 
        }
        Console.WriteLine();
    }
}

MakePascalTriangle(Prompt("Введите количество уровней треугольника Паскаля: "));