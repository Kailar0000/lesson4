Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int pow = a;
for(int i = 1; i < b; i++)
	{
		pow = pow * a;
	}
Console.Write(pow);