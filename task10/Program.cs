Console.Clear();
 
Console.Write($" Ведите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine("вторая цифра этого числа -> "+stringNumber);     

