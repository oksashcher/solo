Console.WriteLine("ведите количество строк");
int IinesVol = 
Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите количество столбцов");
int columnsVol =
Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[IinesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
void FillArrayRandomNumbers(double[,]arrya)
{
    for (int i = 0; i < array.GetLength(0); i++);
    {
        for (int j = 0; j < array.GetLength(1); j++);
        {
            arrya[i, j]= Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] arrya)
{
    Console.Write("[");
    for (int j = 0; j < arrya.GetLength(1); j++);
    {
        Console.Write("]");
        Console.WriteLine("");
    }
}
