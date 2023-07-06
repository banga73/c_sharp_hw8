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

int[] StringFromArray(int[,] array, int StrNum)
{
	int[] RezAr = new int[array.GetLength(1)];
	for (int i = 0; i < array.GetLength(1); i++)
		RezAr[i] = array[StrNum, i];
	return RezAr;
}

int[] OrderArray(int[] StrArr)
{
	int n;
	for (int i = 0; i < StrArr.Length; i++)
	{
		for (int j = 0; j < StrArr.Length - 1; j++)
		{
			if (StrArr[j+1] > StrArr[j])
			{
				n = StrArr[j+1];
				StrArr[j+1] = StrArr[j];
				StrArr[j] = n;
			}		
		}
	}
	return StrArr;
}

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());
int[,] NewArray = RandomTwoIntArray(rows, columns, 0, 1000);
int[,] RezArray = new int[NewArray.GetLength(0), NewArray.GetLength(1)];
PrintTwoArray(NewArray);
Console.WriteLine();
int[] StrArr = new int[NewArray.GetLength(1)];
int[] OrdStr = new int[NewArray.GetLength(1)];
for (int j = 0; j < NewArray.GetLength(0); j++)
{
	StrArr = StringFromArray(NewArray, j);
	OrdStr = OrderArray(StrArr);
	for (int i = 0; i < OrdStr.Length; i++)
		RezArray[j, i] = OrdStr[i];
}
PrintTwoArray(RezArray);