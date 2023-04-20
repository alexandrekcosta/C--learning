using System.Globalization;

string[] Product1 = Console.ReadLine().Split(' ');
int code = int.Parse(Product1[0]);
int quantity = int.Parse (Product1[1]);
double price = double.Parse(Product1[2], CultureInfo.InvariantCulture);

string[] Product2 = Console.ReadLine().Split(' ');
int code0 = int.Parse(Product2[0]);
int quantity0 = int.Parse(Product2[1]);
double price0 = double.Parse(Product2[2], CultureInfo.InvariantCulture);

double t = price * quantity;
double t0 = price0 * quantity0;
double total = t + t0;

Console.WriteLine("TOTAL VALUE TO PAY = {0}", total.ToString("F2", CultureInfo.InvariantCulture));


