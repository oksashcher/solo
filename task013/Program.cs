﻿Console.Clear();
Console.Write("Ведите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
    Console.WriteLine( "Третья цифра -> " + anyNumberText);
}
else {
    Console.WriteLine("->третьей цифры нет");
}
