﻿using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');
string name = vet[0];
char gender = char.Parse(vet[1]);
int age = int.Parse(vet[2]);
double height = double.Parse(vet[3], CultureInfo.InvariantCulture);

Console.WriteLine("You input: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine(name);
Console.WriteLine(gender);
Console.WriteLine(age);
Console.WriteLine(height.ToString("F2",CultureInfo.InvariantCulture));
