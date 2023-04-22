Console.WriteLine("Enter hour: ");
int hour = int.Parse(Console.ReadLine());

if (hour < 12){

    Console.WriteLine("Good morning!");

}else if(hour < 18){

    Console.WriteLine("Good afternoon!");

}else{

    Console.WriteLine("Good evening!");

}
