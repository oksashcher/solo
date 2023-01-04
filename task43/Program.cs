Console.WriteLine("ведите значение b1");
double b1 = 
Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите значение k1");
double k1 =
Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите значение b2");
double b2 =
Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ведите значение k2");
double k2 = 
Convert.ToInt32(Console.ReadLine());
double numberX = (b2 - b1)/(k1 - k2);
double numberY = k2 * numberX + b2;
Console.WriteLine($"точка пересечения двух прямых : {numberX},{numberY}");

