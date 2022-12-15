
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
		Console.Write($"Введите {i+1}-ой элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] array2 = new int[n];
InputArray(array);
Console.Write("Введите число сдвига: ");
int x = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < n; i++)
{
		if((i+x)<0)
		{
			array2[n+i+x] = array[i];
		}
		else if((i+x)>n)
		{
			array2[i+x-n] = array[i];
		}
		else
		{
			array2[i+x] = array[i];
		}
}
Console.WriteLine($"[{string.Join(", ", array2)}]");