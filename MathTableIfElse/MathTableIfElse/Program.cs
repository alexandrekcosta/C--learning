Console.WriteLine("Enter an option(1 - sum,2 - subtraction,3 - multiplication,4 - division): ");
int option = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 1st and 2nd numbers: ");
string[] vet = Console.ReadLine().Split(' ');
int n1 = int.Parse(vet[0]);
int n2 = int.Parse(vet[1]);

if(option == 1){

    int sum = n1 + n2;
    Console.WriteLine("{0} + {1} = {2}", n1, n2, sum);

}else if(option == 2){

    int subtraction = n1 - n2;
    Console.WriteLine("{0} - {1} = {2}", n1, n2, subtraction);

}else if(option == 3){

    int multiplication = n1 * n2;
    Console.WriteLine("{0} * {1} = {2}", n1, n2, multiplication);

}else if(option == 4){

    int division = n1 / n2;
    Console.WriteLine("{0} / {1} = {2}", n1, n2, division);

}else{

    Console.WriteLine("INVALID OPTION");

}
