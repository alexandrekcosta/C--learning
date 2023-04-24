using System.Globalization;
string name;
string country;
int population;
int areakm2;
double gdp;
double gdpcapita;
int PercentValue;

Console.WriteLine("Enter name of city: ");
name = Console.ReadLine();
Console.WriteLine("Enter name of country where city is located in: ");
country = Console.ReadLine();
Console.WriteLine("Enter population of {0}: ",name);
population = int.Parse(Console.ReadLine());
Console.WriteLine("Enter area km per square of {0}: ",name);
areakm2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter GDP of {0}: ",country);
gdp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Enter GDP per capita of {0}: ",name);
gdpcapita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Enter percent value: ");
PercentValue = int.Parse(Console.ReadLine());



if(population < 20000 && gdpcapita < 2000 && areakm2 < 100000){
    double FundValue = gdp - (gdp * PercentValue / 100);
    double t = FundValue - gdp;
    Console.WriteLine("THIS CITY IS ELEGIBLE FOR EXTRA-MUNICIPAL FUND");
    Console.WriteLine("EXTRA-MUNICIPAL FUND VALUE:{0} ",t.ToString("F2",CultureInfo.InvariantCulture));

}else{

    Console.WriteLine("THIS CITY ISN'T ELEGIBLE FOE EXTRA-MUNICIPAL FUND");

}
