﻿


int [,] matrix = new int [3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       Console.Write($"{matrix[i,j]} "); 
    }
    System.Console.WriteLine();
}