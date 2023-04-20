// See https://aka.ms/new-console-template for more information

using System.Globalization;

string product1 = "Computer";
string product2 = "Table for office";

string name = "Mehwish";
int age = 21;
int code = 5290;
char gender = 'F';

double price1 = 2100.0;
double price2 = 650.50;

double measure = 53.234567;

Console.WriteLine("Products: ");
Console.WriteLine("{0}: R${1}",product1,price1);
Console.WriteLine("{0}: R${1}",product2,price2);
Console.WriteLine("------------");
Console.WriteLine($"Register: {name},{age} years old,code:{code},gender:{gender}");
Console.WriteLine("------------");
Console.WriteLine("{0:F8}",measure);
Console.WriteLine($"{measure:F3}");
Console.WriteLine(measure.ToString("F3", CultureInfo.InvariantCulture));
