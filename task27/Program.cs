Console.Clear();
Console.Write("Введите число: ");
string? number = Console.ReadLine();
int N = number.Length;
int sum = 0;
int a = 0;

for(int i = 0; i < N; i++)
{
		a = Convert.ToInt32(number[i].ToString());
		sum = sum + a;
}
Console.Write(sum);