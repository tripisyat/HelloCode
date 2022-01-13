
// задаем двумерный массив состоящий из строк
string[,] table = new string[2, 5];
// table[0,0] table[0,1] table[0,2] ... table[0,4]
// table[1,0] table[1,1] table[1,2] ... table[1,4]

table[1,2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}



// задаем двумерный массив состоящий из чисел
int [,] matrix = new int [3,4];
for (int i = 0; i < matrix.GetLength(0); i++) // создаем строки; аргумент 0  функции GetLength означает отсыл к 3 в new int [3,4]
{
    for (int j = 0; j < matrix.GetLength(1); j++) //создаем столбцы согласно созданным строкам
    {
       Console.Write($"{matrix[i,j] } "); 
    }
    Console.WriteLine();
}


//заполняем двумерный массив

void PrintArray(int [,] matr) // метод распечатывания массива в терминале
{
for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
        Console.Write($"{matr[i,j] } "); 
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] matr) // метод заполнения массива рандомными числами от 0 до 9
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
int [,] matr = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// вычисляем факториал
int factorial(int n)
{
    if (n==1) return 1;
    else return n*factorial(n-1);
}
for (int i = 0; i < 30; i++)
{
    Console.WriteLine($"{i}! = {factorial(i)}");
}