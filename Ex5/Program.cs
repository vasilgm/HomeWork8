// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int a = new Random().Next(4, 5);
int b = new Random().Next(4, 5);
int[,] array = new int [a, b];
//fillingArray (array);
PrintArray (array);
spiralArray(array);
System.Console.WriteLine();
PrintArray (array);


void PrintArray(int[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i, j]<10)
            {
                System.Console.Write($"0{array [i, j]} ");
            }
            else System.Console.Write(array [i, j]+" "); 
        }
        System.Console.WriteLine(" ");
    }
}

void spiralArray (int[,] array)
{
    int N = array.GetLength(0); // Количество строк массива
    int M = array.GetLength(1); // Количество столбцов массива
    int Ibeg = 0; //Верхняя сторона текущего прямоугольника
    int Ifin = 0; //Нижняя сторона текущего прямоугольника
    int Jbeg = 0; //Левая сторона текущего прямоугольника
    int Jfin = 0; //Правая сторона текущего прямоугольника
    int k = 1;
    int i = 0;
    int j = 0;
    while (k <= N * M)
    {
        array[i,j] = k;
        if (i == Ibeg && j < M - Jfin - 1) //Если у нас верхняя сторона прямоугольника и мы не достигла правой стороны, то двигаемся вправо: ++j
            ++j;
        else if (j == M - Jfin - 1 && i < N - Ifin - 1) //Если мы на правой стороне прямоугольника и не достигли нижней стороны, то двигаемся вниз: ++i
            ++i;
        else if (i == N - Ifin - 1 && j > Jbeg) //Если мы на нижней стороне прямоугольника и не достигли левой стороны, то двигаемся влево: --j
            --j;
        else //Иначе двигаемся вверх: --i
            --i;
    
    
    if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
    {
        Ibeg++;
        Ifin++;
        Jbeg++;
        Jfin++;
    }
        k++;
    }
    
}