Console.WriteLine("Input a 1st number: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input a 2nd number: ");
int n2 = int.Parse(Console.ReadLine());

int sum = n1 + n2;
int sub = n1 - n2;
int multiplication = n1 * n2;
int division = n1 / n2;

Console.WriteLine(" ");
Console.WriteLine("SUM: {0} + {1} = {2}", n1, n2, sum);
Console.WriteLine("SUBTRACTION: {0} - {1} = {2}", n1, n2, sub);
Console.WriteLine("MULTIPLICATION: {0} * {1} = {2}", n1, n2, multiplication);
Console.WriteLine("DIVISION: {0} / {1} = {2}", n1, n2, division);
