using System.Globalization;

double area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double formula = Math.PI * Math.Pow(area, 2);

Console.WriteLine("A = "+formula.ToString("F4", CultureInfo.InvariantCulture));
