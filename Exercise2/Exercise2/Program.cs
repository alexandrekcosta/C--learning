using System.Globalization;

string name = Console.ReadLine();
int rooms = int.Parse(Console.ReadLine());
double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');
string name0 = vet[0];
int age0 = int.Parse(vet[1]);
double height = double.Parse(vet[2],CultureInfo.InvariantCulture);

Console.WriteLine("You input: ");
Console.WriteLine(name);
Console.WriteLine(rooms);
Console.WriteLine(price.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine(name0);
Console.WriteLine(age0);
Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
