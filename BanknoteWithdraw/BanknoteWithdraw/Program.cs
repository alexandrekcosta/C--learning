using System.Globalization;
Console.WriteLine("ENTER A QUANTITY TO WITHDRAW: ");
double quantity = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double _100bn = quantity / 100;
double _50bn = quantity / 50;
double _20bn = quantity / 20;
double _10bn = quantity / 10;
double _5bn = quantity / 5;
double _2bn = quantity / 2;

Console.WriteLine(" ");
Console.WriteLine("TOTAL QUANTITY: {0}", quantity.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("100 REAIS BANKNOTES:{0}", _100bn.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("50 REAIS BANKNOTES: {0}", _50bn.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("20 REAIS BANKNOTES: {0}", _20bn.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("10 REAIS BANKNOTES: {0}", _10bn.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("5 REAIS BANKNOTES: {0}", _5bn.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("2 REAIS BANKNOTES: {0}", _2bn.ToString("F2", CultureInfo.InvariantCulture));
