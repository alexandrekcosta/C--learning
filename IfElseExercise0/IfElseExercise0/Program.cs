string[] vet = Console.ReadLine().Split(' ');
int a = int.Parse(vet[0]);
int b = int.Parse(vet[1]);

int result = a * b;

if(a % b == 0 || b % a == 0){

    Console.WriteLine("MULTIPLE NUMBERS");

}else{

    Console.WriteLine("NON-MULTIPLE NUMBERS");

}
