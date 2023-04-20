using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');
double a = double.Parse(vet[0],CultureInfo.InvariantCulture);
double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

double TriangleRetangle = (a * c) / 2;
double circle = Math.PI * Math.Pow(c, 2);
double t = (a + b) * c / 2;
double square = Math.Pow(b, 2);
double retangle = a * b;

Console.WriteLine("TRIANGLE RETANGLE = {0}", TriangleRetangle.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCLE = {0}", circle.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZE = {0}", t.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("SQUARE = {0}", square.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGLE = {0}", retangle.ToString("F2", CultureInfo.InvariantCulture));
