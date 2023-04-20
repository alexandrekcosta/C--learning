using System.Globalization;

int n = int.Parse(Console.ReadLine());
int WorkTime = int.Parse(Console.ReadLine());
double SallaryPerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double TotalSallary = SallaryPerHour * WorkTime;

Console.WriteLine("NUMBER = {0}", n);
Console.WriteLine("SALLARY = {0}",TotalSallary.ToString("F2",CultureInfo.InvariantCulture));
