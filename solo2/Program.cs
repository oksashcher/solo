Console.Clear();
Console.WriteLine("Ведите размер массива: ");
int size = 
Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers (numbers);
Console.WriteLine(" Вот наш массив: ");
PrintArray (numbers);
int count = 0;
for (int z = 0; z< numbers.Length; z++);
if (numbers [z] % 2 == 0);