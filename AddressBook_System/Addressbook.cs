using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_System
{
    internal class Addressbook
    {
        List<Contact> addressList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            addressList.Add(contact);
        }
        public void EditContact(string name)
        {
            foreach (var contact in addressList)
            {
                if (contact.UniqueName == name)
                {
                    Console.WriteLine("Choose the field you want to edit : \n 1. First name \n 2. Last name \n 3. Address \n 4. City \n 5. State \n 6. Zip code \n 7. Phone Number \n 8. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter you want to edit");
                            string first = Console.ReadLine();
                            contact.FirstName = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter you want to edit");
                            string last = Console.ReadLine();
                            contact.LastName = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter you want to edit");
                            string address = Console.ReadLine();
                            contact.Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter you want to edit");
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter you want to edit");
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter you want to edit");
                            string zip = Console.ReadLine();
                            contact.Zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter you want to edit");
                            string phone = Console.ReadLine();
                            contact.MobileNumber = phone;
                            break;
                        case 8:
                            Console.WriteLine("Enter you want to edit");
                            string email = Console.ReadLine();
                            contact.Email = email;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string name)
        {
            
            foreach (var contact in addressList)
            {
                if (contact.UniqueName == name)
                {
                    addressList.Remove(contact);
                }
            }

            Console.WriteLine(name + " contact is deleted from the Address Book");
        }
        public void Display()
        {
            Console.WriteLine("Contacts in Your Device : ");
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.City + "\n" + contact.MobileNumber + "\n" + contact.Zip + "\n" + contact.Address + "\n" + contact.Email + "\n" + contact.State);
            }
        }
        public void CheckDuplicateEntry()
        {
            Console.WriteLine("Enter the Name to Check whether the name is Duplicate or not");
            string checkD = Console.ReadLine();
            
            var person = addressList.Find(e => e.FirstName.Equals(checkD));
            if (person == null)
            {
                Console.WriteLine("The Name you are trying to check is Not in the Address Book");
            }
            else
            {
                Console.WriteLine("Error occured ! The Name : {0}, is already Exists in Address Book", checkD);
            }
        }
    }
}
