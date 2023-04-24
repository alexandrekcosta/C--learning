using System.Globalization;
string name;
string country;
int population;
int areakm2;
double gdp;
double gdpcapita;

Console.WriteLine("Enter name of city: ");
name = Console.ReadLine();
Console.WriteLine("Enter name of country where city is located in: ");
country = Console.ReadLine();
Console.WriteLine("Enter population of city: ");
population = int.Parse(Console.ReadLine());
Console.WriteLine("Enter area km per square of city: ");
areakm2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter GDP of {0}: ",country);
gdp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Enter GDP per capita of city: ");
gdpcapita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(population < 20000 && gdpcapita < 2000.0 && areakm2 < 100000.0){

    Console.WriteLine("THIS CITY IS ELEGIBLE FOR EXTRA-MUNICIPAL FUND");

}else{

    Console.WriteLine("THIS CITY ISN'T ELEGIBLE FOE EXTRA-MUNICIPAL FUND");

}
