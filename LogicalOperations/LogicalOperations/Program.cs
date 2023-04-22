bool c1 = 4 != 5;
bool c2 = 2 > 3 && 4 != 5;
bool c3 = 2 > 3 || 4 != 5;
bool c4 = !(2 > 3) && 4 != 5;
bool c5 = c1 || c2 && c3;

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);
Console.WriteLine(c4);
Console.WriteLine(c5);
