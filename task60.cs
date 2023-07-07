int[,,] RandomThreeIntArray(int UserRows, int UserColomns, int UserSlice, int UserMin, int UserMax) //input random integer array
{
	int[,,] IntArray = new int[UserRows, UserColomns, UserSlice];
	Random RandTemp = new Random();
	for (int i = 0; i < UserRows; i++)
	{
		for (int j = 0; j < UserColomns; j++)
		{
			for (int k = 0; k < UserSlice; k++)
				IntArray[i, j, k] = new Random().Next(UserMin, UserMax); 
		}
	}
	return IntArray;
}

void PrintThreeArray(int[,,] array) // print 2-dim array
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(2); k++)
				Console.Write($"{array[i,j, k]}({i},{j},{k}) ");
			Console.WriteLine();
		}
	}
}
		
Console.Write("Input rows ");
int UserRows=int.Parse(Console.ReadLine());
Console.Write("Input colomns  ");
int UserColumns=int.Parse(Console.ReadLine());
Console.Write("Input slices  ");
int UserSlices=int.Parse(Console.ReadLine());
int[,,] UserArray = RandomThreeIntArray(UserRows, UserColumns, UserSlices, 0, 1000);
PrintThreeArray(UserArray);