// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int a = new Random().Next(1, 9);
int b = new Random().Next(1, 9);
int[,] array1 = new int [a, b];
int[,] array2 = new int [a, b];
fillingArray (array1);
fillingArray (array2);
PrintArray (array1);
System.Console.WriteLine(" ");
PrintArray (array2);
int[,] array3 = multiplyArray (array1, array2);
System.Console.WriteLine(" ");
PrintArray (array3);


int[,] multiplyArray (int[,] array1, int[,] array2)
{
    int[,] multiplyArray = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i <array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            multiplyArray[i,j] = 0;
            for (int k = 0; k < array1.GetLength(0); k++)
            {
                multiplyArray[i,j] += array1[i, k]*array2[k,j];
            }
        }
    }
    return multiplyArray;
}

void fillingArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array [i, j] + " "); 
        }
        System.Console.WriteLine(" ");
    }
}