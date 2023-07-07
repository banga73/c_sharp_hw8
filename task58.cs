int[,] RandomTwoIntArray(int UserRows, int UserColomns, int UserMin, int UserMax) //input random integer array
{
	int[,] IntArray = new int[UserRows, UserColomns];
	Random RandTemp = new Random();
	for (int i = 0; i < UserRows; i++)
	{
		for (int j = 0; j < UserColomns; j++)
		{
			IntArray[i, j] = new Random().Next(UserMin, UserMax); 
		}
	}
	return IntArray;
}

void PrintTwoArray(int[,] TwoArray) // print 2-dim array
{
	for (int i = 0; i < TwoArray.GetLength(0); i++)
	{
		for (int j = 0; j < TwoArray.GetLength(1); j++)
			Console.Write($"{TwoArray[i,j]} ");
		Console.WriteLine();
	}
}
int[,] MultMat(int[,] array1, int[,] array2) //muliply matrix (where array1.GetLength(1)=array2.GetLength(0))
{
	int[,] Mult = new int[array1.GetLength(0), array2.GetLength(1)];
	for (int i = 0; i < array1.GetLength(0); i++)
		{
			for (int j = 0; j < array2.GetLength(1); j++)
			{
				for (int k = 0; k < array1.GetLength(1); k++)
					Mult[i,j] = Mult[i,j] + array1[i,k]*array2[k,j];
			}
		}
	return Mult;
}
		
Console.Write("Введите количество строк матрицы А: ");
int rowsA=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int columnsA=int.Parse(Console.ReadLine());
Console.Write("Введите количество строк матрицы В: ");
int rowsB=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы В: ");
int columnsB=int.Parse(Console.ReadLine());		
if (columnsA == rowsB)
{
	int[,] NewMatrA = RandomTwoIntArray(rowsA, columnsA, 0, 1000);
	int[,] NewMatrB = RandomTwoIntArray(rowsB, columnsB, 0, 1000);
	int[,] MultMatrAB = new int[rowsA, columnsB];
	MultMatrAB = MultMat(NewMatrA, NewMatrB);
	PrintTwoArray(NewMatrA);
	Console.WriteLine();
	PrintTwoArray(NewMatrB);
	Console.WriteLine();
	PrintTwoArray(MultMatrAB);
}
else Console.Write("You can't multiply these matrixes");