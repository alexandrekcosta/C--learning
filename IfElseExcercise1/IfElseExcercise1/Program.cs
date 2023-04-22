using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');
int code = int.Parse(vet[0]);
int quantity = int.Parse(vet[1]);

if(code == 1){

    double c1 = 4.00 * quantity;
    Console.WriteLine("TOTAL R${0}", c1.ToString("F2",CultureInfo.InvariantCulture));
}else if(code == 2){

    double c2 = 4.50 * quantity;
    Console.WriteLine("TOTAL R${0}", c2.ToString("F2",CultureInfo.InvariantCulture));

}else if(code == 3){

    double c3 = 5.00 * quantity;
    Console.WriteLine("TOTAL R${0}", c3.ToString("F2",CultureInfo.InvariantCulture));

}else if(code == 4){

    double c4 = 2.00 * quantity;
    Console.WriteLine("TOTAL R${0}", c4.ToString("F2",CultureInfo.InvariantCulture));

}else if(code == 5){

    double c5 = 1.50 * quantity;
    Console.WriteLine("TOTAL R${0}", c5.ToString("F2",CultureInfo.InvariantCulture));

}
else{

    Console.WriteLine("INVALID INPUT!");

}

