using System.Globalization;

double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double discount = 0.0;

if (price > 100.0){

    discount = price * 0.1;

}

Console.WriteLine(discount.ToString("F2", CultureInfo.InvariantCulture));
