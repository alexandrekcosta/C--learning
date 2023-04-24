using System.Globalization;
double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(n >= 0.00 && n <= 2000.00){

    Console.WriteLine("NO NEED TO PAY TAXES");

}else if(n >= 2000.01 && n <= 3000.00){

    double TaxFormula = n * 0.8;
    Console.WriteLine("R${0}",TaxFormula.ToString("F2",CultureInfo.InvariantCulture));


}else if(n >= 3000.01 && n <= 45000.00){

    double TaxFormula = n * 0.18;
    Console.WriteLine("R${0}",TaxFormula.ToString("F2",CultureInfo.InvariantCulture));

}else{

    double TaxFormula = n * 0.28;
    Console.WriteLine("R${0}", TaxFormula.ToString("F2", CultureInfo.InvariantCulture));

}
