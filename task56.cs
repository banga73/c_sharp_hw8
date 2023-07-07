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
int NumMinEl(int[] array)
{
	int minel = array[0];
	int MunMinEl = 0;
	for (int j = 1; j < array.Length; j++)
		if (array[j] < minel) 
		{
			minel = array[j];
			MunMinEl = j;
		}
	return MunMinEl+1;
}
		
Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());
int[,] NewArray = RandomTwoIntArray(rows, columns, 0, 1000);
int[] SumStr = new int[NewArray.GetLength(0)];
int MinSum = 0;
PrintTwoArray(NewArray);
Console.WriteLine();
for (int i = 0; i < NewArray.GetLength(0); i++)
{
	for (int j = 0; j < NewArray.GetLength(1); j++)
		SumStr[i] = SumStr[i] + NewArray[i,j];
}
MinSum = NumMinEl(SumStr);
Console.Write($"The String with min sum of elements is {MinSum}");