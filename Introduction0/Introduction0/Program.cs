// See https://aka.ms/new-console-template for more information

using System.Globalization;

int age = 21;
double ballance = 10.35784;
string name = "Mehwish";

Console.WriteLine("{0} is {1} years old and has a ballance that equals {2:F2} rupees",name,age,ballance);
Console.WriteLine($"{name} is {age} years old and has a ballance that equals {ballance:F2} rupees");
Console.WriteLine(name + " is " + age + " years old and has a ballance that equals " + ballance.ToString("F2",CultureInfo.InvariantCulture) + " rupees");
