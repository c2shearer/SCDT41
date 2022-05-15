namespace Cleaning_Service
{
    public class Customer : User
    {
        public char Gender { get; set; }
        public string? Email { get; set; }
        public string Telephone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }

        private static List<Customer> Customers = new List<Customer>();

        public Customer(string FirstName, string LastName, char Gender, string Email, string Telephone, string Address, string City, string County)
        {
            Id = Guid.NewGuid();
            this.FirstName = FirstName;
            this.LastName = LastName;
            IsAdmin = false;
            this.Gender = Gender;
            this.Email = Email.Contains('@') ? Email : "Email not valid, re-enter";
            this.Telephone = Telephone;
            this.Address = Address;
            this.City = City;
            this.County = County;
        }

        public static void AddCustomer()
        {
            Console.WriteLine("Customer First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Customer Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Customer Gender: ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Customer Email Address: ");
            string emailAddress = Console.ReadLine();
            Console.WriteLine("Customer Telephone: ");
            string telephone = Console.ReadLine();
            Console.WriteLine("Customer Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Customer City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Customer County: ");
            string county = Console.ReadLine();
            Customers.Add(new Customer(firstName, lastName, gender, emailAddress, telephone, address, city, county));
        }

        public static void DeleteCustomer()
        {
            Console.WriteLine("Enter Customer GUID: ");
            string customerId = Console.ReadLine();
            var toRemove = Customers.SingleOrDefault(r => Convert.ToString(r.Id) == customerId);
            if (toRemove != null)
                Customers.Remove(toRemove);
            else
                Console.WriteLine("No Customer Found");
        }

        public static void CustomerList()
        {
            int x = 0;
            foreach (Customer customer in Customers)
            {
                Console.WriteLine($"Customer {++x}\n{customer}");
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Gender} : {Id}\nContact: {Email} + {Telephone}\n{Address}, {City}, {County}";
        }
    }
}
