
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    
}


void SecondArray(string[] massiv, string[] new_massiv)
{
    int count = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
    if(massiv[i].Length <= 3)
        {
        new_massiv[count] = massiv[i];
        count++;
        }
    }
}  

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] massiv = new string[n]; //{"Hello", "asdsd", "world", "add22", "Hello"};
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = Console.ReadLine()!;
}

string[] new_massiv = new string[massiv.Length];

SecondArray(massiv, new_massiv);
Console.WriteLine($"В массиве [{string.Join(",", massiv)}] строки с колличеством символов 3 либо меньше : ");
PrintArray(new_massiv);

