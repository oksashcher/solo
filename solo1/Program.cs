Console.Clear();
Console.WriteLine("Ведите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] mass = new int [n]; 
for (int i = 0; i < n; i++)
{ Console.Write($"Ведите {i}й элемент: "); mass[i] = Convert.ToInt32(Console.ReadLine());}
int min = 0;
int max = 0;
foreach (int i in mass)
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n  Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max- min}" );