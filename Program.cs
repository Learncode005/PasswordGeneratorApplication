// See https://aka.ms/new-console-template for more information
//Random function use 
//Datetime use
//Admin has to give one password every time, instead of manual thinking
//we are generating password
Console.WriteLine("                 Welcome to password generator");

//Random function use 
DateTime currentDate = DateTime.Now;
Console.WriteLine("                 Current Date: " + currentDate.ToString("d"));
Console.WriteLine("............................................................");
GeneratePassword();
void GeneratePassword()
{
    Random random = new Random();

    for (int i = 0; i < 2; i++)
    {
        int randomIntInRangeValue = random.Next(1000, 100000);
        Console.WriteLine(" ");
        Console.WriteLine("                 Password value is " + randomIntInRangeValue);
    }




    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}



Console.WriteLine("Do you want to generate password , Press 1 to generate");
int UserInput = Console.Read();

Console.WriteLine(UserInput);

if(Convert.ToChar(UserInput) == 49)
{
    Console.WriteLine("Password is generating please wait");
    GeneratePassword();
    Console.WriteLine("Do you want to generate password , Press 1 to generate");

    Console.Read();
}
Console.Read();
