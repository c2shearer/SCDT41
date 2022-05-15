using Cleaning_Service;

// Declare Super Admin
Admin systemAdmin = new("Cameron", "Shearer", "cls@btc.ac.uk", "password");

for (int i = 3; i != 0; i--)
{
    Console.WriteLine("Enter Administrator Username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Administrator Password: ");
    string password = Console.ReadLine();

    if (username != systemAdmin.Username && password != systemAdmin.Password)
    {
        Console.WriteLine("Incorrect Username or Password");

    }
    else if (i == 0)
    {
        Console.WriteLine("Attempts failed, application terminated");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Logged in as {systemAdmin.Username}");
        char option = '\0';
        char subOption = '\0';
        do
        {
            Console.WriteLine("Select an Option from the following\nA) Manage Customers\nB) Manage Bookings\nC) Purchase Materials\nD) Exit");
            option = Convert.ToChar(Console.ReadLine().ToLower());
            switch (option)
            {
                case 'a':
                    Console.WriteLine("Manage Customer Options\nA) Add Customer \nB) Delete Customer \nC) View Customers");
                    subOption = Convert.ToChar(Console.ReadLine().ToLower());
                    if (subOption == 'a')
                    {
                        Customer.AddCustomer();
                    }
                    else if (subOption == 'b')
                    {
                        Customer.DeleteCustomer();
                    } 
                    else if (subOption == 'c')
                    {
                        Customer.CustomerList();
                    }
                    else
                    {
                        Console.WriteLine("Option not found");
                    }
                    break;
                case 'b':
                    Console.WriteLine("Manage Bookings Options\nA) Add Booking\nB) Close Booking\nC) View Booking Details");
                    subOption = Convert.ToChar(Console.ReadLine().ToLower());
                    if (subOption == 'a')
                    {

                    } 
                    else if (subOption == 'b')
                    {

                    }
                    else if (subOption == 'c')
                    {

                    }
                    else
                    {
                        Console.WriteLine("Option not found");
                    }

                    break;

                // Finished
                case 'c':
                    Console.WriteLine("Manage Materials\nA) Log Material\nB) View Purchases\nC) Back");
                    subOption = Convert.ToChar(Console.ReadLine().ToLower());
                    if (subOption == 'a')
                    {
                        Material.AddMaterial();
                    }
                    else if (subOption == 'b')
                    {
                        Material.MaterialPurchased();
                    }
                    else if (subOption == 'c')
                    {
                        Console.WriteLine("Back to Main Menu");
                    }
                    else
                    {
                        Console.WriteLine("Option not found");
                    }
                    break;
                case 'd':
                    Console.WriteLine("Exiting Application");
                    break;
                default:
                    Console.WriteLine("Option not found");
                    break;
            }
        } while (option != 'd');
        break;
    }
}



/*Customer Cameron = new("Cameron", "Shearer", 'M', "cam@btc.ac.uk", "07884942572", "123 Road", "Bridgwater", "Somerset");

Material Mop = new("Mop", "Used for cleaning the floor", 9.99m);
Material Bucket = new("Bucket", "Used for holding water", 4.99m);

EnumProperties.Types();
EnumServices.Types();*/


