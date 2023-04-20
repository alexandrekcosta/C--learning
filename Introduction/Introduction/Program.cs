// See https://aka.ms/new-console-template for more information

using System.Globalization;

char gender = 'F';
int age = 21;
double balance = 10.35784;
string name = "Mehwish";

Console.WriteLine(gender);
Console.WriteLine(age);
Console.WriteLine(balance);
Console.WriteLine(name);
Console.WriteLine(balance.ToString("F2"));
Console.WriteLine(balance.ToString("F4"));
Console.WriteLine(balance.ToString("F4", CultureInfo.InvariantCulture));
