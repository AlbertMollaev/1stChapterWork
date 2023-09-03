


Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] massiv = new string[n]; //{"Hello", "asdsd", "world", "add22", "Hello"};
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = Console.ReadLine()!;
}

string[] new_massiv = new string[massiv.Length];
