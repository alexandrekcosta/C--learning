using System.Globalization;
double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(n >= 0.00 && n <= 25.00){

    Console.WriteLine("NUMBER LOCATED BETWEEN [0,25]");

}else if(n >= 25.00 && n <= 50.00){

    Console.WriteLine("NUMBER LOCATED BETWEEN [25,50]");

}else if(n >= 50.00 && n <= 75.00){

    Console.WriteLine("NUMBER LOCATED BETWEEN [50,75]");

}else if(n >= 75.00  && n <= 100.00){

    Console.WriteLine("NUMBER LOCATED BETWEEN [75,100]");

}else if(n >= 100.00){

    Console.WriteLine("NUMBER LOCATED ABOVE [100]");

}else {

    Console.WriteLine("NUMBER LOCATED BELLOW [0]");

}
