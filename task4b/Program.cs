bool ReleaseNumber(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n-1;
int b = 1;
bool x = false;
bool z = false;

while(x == false)
{
		while(z == false)
		{
			a = a - 1;
            z = ReleaseNumber(a);
		}
	b = n - a;
    x = ReleaseNumber(b);
}

Console.Write($"{b} ; {a}");