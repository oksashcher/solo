Console.Clear();
Console.Write("ведите ряд чисел, разделенных запятой: ");
string? seriesOfNumbers = Console.ReadLine();
seriesOfNumbers = seriesOfNumbers + ",";
string RemovingSpaces (string srries){
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != '')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}
void PrintArry(int[] coll){
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while(index <count){
        Console.Write(coll[index]);
        index++;
        if (index < count){
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);
PrintArry(arrayOfNumbers);

