using System.Globalization;

double n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

if(n >= 0){

    Console.WriteLine("NON-NEGATIVE");

}else{

    Console.WriteLine("NEGATIVE");

}
