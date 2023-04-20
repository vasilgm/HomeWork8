// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int a = new Random().Next(1, 9);
int b = new Random().Next(1, 9);
int[,] array = new int [a, b];
fillingArray (array);
PrintArray (array);
int[] sumArr = sumArray(array);
System.Console.WriteLine("Сумма элементов строк: ");
for (int i = 0; i < sumArr.Length; i++)
{
    System.Console.Write(sumArr[i]+" ");
}
System.Console.WriteLine(" ");
positionMinNumber(sumArr);

void positionMinNumber(int[] sumArr)
{
    int positionNumber = 0;
    int minNumber = sumArr[0];
    for (int i = 0; i < sumArr.Length; i++)
    {
        if (minNumber > sumArr[i])
        {
            minNumber = sumArr[i];
            positionNumber = i;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма элементов > {minNumber} находится на > {positionNumber} строке");
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

int[] sumArray (int[,] array)
{
    int[] sumArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] = sumArray[i]+array[i,j];
        }
    }
    return sumArray;
}