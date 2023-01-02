namespace AddressBook_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Contact contact = new Contact();
            Addressbook addressBook = new Addressbook();
            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book Program\n");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Edit Contact \n 4. Delete Contact \n 5. Add Multiple Contact \n 6. Check For Duplicate Entry \n 7. Searsh Contact \n 8. Count Contact by City or State \n 9. Sort Person Name \n 10. Read or Write in Address Book Using File I/O \n 11. Read And Write By using CSV File \n 12. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email, UniqueName : ");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            UniqueName = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Mobile Number, Email, UniqueName");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            UniqueName = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Unique Name to  Edit: ");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        Console.WriteLine("Contact is Edited Sucsessfully");
                        addressBook.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Unique name of contact you want to delete :");
                        string detail = Console.ReadLine();
                        Addressbook delete = new Addressbook();
                        delete.DeleteContact(detail);
                        delete.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email, UniqueName");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            UniqueName = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        Console.WriteLine("Contact is Saved");
                        addressBook.Display();
                        break;
                    case 6:
                        addressBook.CheckDuplicateEntry();
                        break;
                    case 7:
                        addressBook.SearchContact();
                        break;
                    case 8:
                        addressBook.CountContact();
                        break;
                    case 9:
                        addressBook.AddressBookSorting();
                        break;
                    case 10:
                        addressBook.ReadFile();
                        addressBook.WritingUsingStreamWriter();
                        break;
                    case 11:
                        addressBook.ReadWriteAsCsv();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
            }
        }  
    }
}