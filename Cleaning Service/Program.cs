using Cleaning_Service;

Customer Cameron = new Customer("Cameron", "Shearer", 'M', "cambtc.ac.uk", "07884942572", "123 Road", "Bridgwater", "Somerset");
Admin NewAdmin = new Admin("John", "Doe", "johndoe", "test");

string pass = Console.ReadLine();

if (pass != NewAdmin.Password)
{
    Console.WriteLine("Error");
} else
{
    Console.WriteLine("Welcome");
}

Console.WriteLine(Cameron);
