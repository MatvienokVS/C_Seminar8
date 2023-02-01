//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using static System.Console;
Clear();

Write("Введите параметры массива 1: ");
int[] par = Array.ConvertAll(ReadLine()!.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

Write("Введите параметры массива 2: ");
int[] par2 = Array.ConvertAll(ReadLine()!.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);


int[,] array1 = GetDDArray(par[0], par[1], par[2], par[3]);
int[,] array2 = GetDDArray(par2[0], par2[1], par2[2], par2[3]);
int[,] resultArray = new int[par[0], par[1]];

WriteLine("array1");
PrintDDArray(array1);

WriteLine("array2");
PrintDDArray(array2);

WriteLine("Результат умножения");
resultArr(array1, array2, resultArray);
PrintDDArray(resultArray);


void resultArr(int[,] array, int[,] array2, int[,] resultArray)
{
	if (array1.GetLength(0) != array2.GetLength(1))
	{
		WriteLine("Умножение невозможно!!!");
		return;
	}

	for (int i = 0; i < array1.GetLength(0); i++)
	{
		for (int j = 0; j < array2.GetLength(1); j++)
		{
			//resultArray[i, j] = 0;
			for (int k = 0; k < array1.GetLength(1); k++)
			{
				resultArray[i, j] += array1[i, k] * array2[k, j];
			}
		}
	}
}



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
