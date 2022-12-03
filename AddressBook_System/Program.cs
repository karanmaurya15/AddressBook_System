namespace AddressBook_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Mobilenumber, Email");
            ContactDetails contact = new ContactDetails()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Console.ReadLine(),
                MobileNumber = Console.ReadLine(),
                Email = Console.ReadLine(),
            };
        }
    }
}