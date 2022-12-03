namespace AddressBook_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
          
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Mobile Number: ");
            long mobileNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter EMail: ");
            string eMail = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip: ");
            int zip = Convert.ToInt32(Console.ReadLine());

            ContactDetails contact = new ContactDetails()
            {

                FirstName = firstName,
                LastName = lastName,
                MobileNumber = mobileNumber,
                Email = eMail,
                Address = address,
                City = city,
                State = state,
                Zip = zip
            };
            Addressbook addressbook = new Addressbook();
            addressbook.AddContact(contact);
            addressbook.Display();
        }
    }
}