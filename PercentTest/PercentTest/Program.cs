using System.Globalization;
double t = 0;
Console.WriteLine("Enter a value: ");
float n = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Enter percentage value: ");
int PercentValue = int.Parse(Console.ReadLine());

double stv = n - (n * PercentValue / 100);
 t = stv - n;

Console.WriteLine("{0}", t);
