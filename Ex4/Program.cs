// Задача 60. ...Сформируйте трёхмерный массив из случайных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int c = new Random().Next(1, 10);
int[,,] array1 = new int [a, b, c];
System.Console.WriteLine($"Массив размером > {a} х {b} х {c}");
fillingArray1(array1);
printArray1(array1);

void fillingArray1(int[,,] array1)
{
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        for (int k = 0; k < array1.GetLength(2); k++)
        {
            array1 [i,j,k] = new Random().Next(1, 9);
        }
    }
}
}

void printArray1(int[,,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        for (int k = 0; k < array1.GetLength(2); k++)
        {
            System.Console.Write($"{array1 [i,j,k]} ({i},{j},{k}) ");
        }
        System.Console.WriteLine("");
    }
}
}