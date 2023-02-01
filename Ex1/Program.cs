//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

using static System.Console;
Clear();

Write("Введите параметры массива: ");

int[] par = Array.ConvertAll(ReadLine()!.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetDDArray(par[0], par[1], par[2], par[3]);

PrintDDArray(array);
SortNewArray(array);
WriteLine("отсортированный массив:");
PrintDDArray(array);


int[,] GetDDArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] Array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return Array;
}

void PrintDDArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5}");
        }
        WriteLine();
    }

}

void SortNewArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int n = 0; n < inArray.GetLength(1)-1; n++)
            {
                if (inArray[i, n] < inArray[i,n+1])
                {
                    int temp = inArray[i, n + 1];
                    inArray[i, n + 1] = inArray[i, n];
                    inArray[i, n] = temp;
                }
            }
        }
    }
}
