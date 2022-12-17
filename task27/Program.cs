Console.Clear();
Console.WriteLine("ведите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int number){
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++){
        advance = numberN - number % 10;
        result = result + (numberN - advance);
        number = number / 10;
    }
    return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine("сумма цифр в числе: " + sumNumber);

