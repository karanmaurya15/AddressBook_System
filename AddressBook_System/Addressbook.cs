using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;

namespace AddressBook_System
{
    internal class Addressbook
    {
        List<Contact> addressList = new List<Contact>();
        Dictionary<string, List<Contact>> dictionary = new Dictionary<string, List<Contact>>();
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
            Console.WriteLine("\nContacts in Your Device : ");
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + "\t" + contact.LastName + "\t" + contact.City + "\t" + contact.MobileNumber + "\t" + contact.Zip + "\t" + contact.Address + "\t" + contact.Email + "\t" + contact.State);
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
        public void SearchContact()
        {
            Console.WriteLine("\nEnter 1 to Search by City \nEnter 2 to Search by State");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Enter City: ");
                string city = Console.ReadLine();
                var DuplicateCheck = addressList.Where(e => e.City.Equals(city));
                foreach (var contact in DuplicateCheck)
                {
                    Console.WriteLine(contact.FirstName + "\t" + contact.LastName + "\t" + contact.City + "\t" + contact.MobileNumber + "\t" + contact.Zip + "\t" + contact.Address + "\t" + contact.Email + "\t" + contact.State);
                }
            }
            if (input == 2)
            {
                Console.WriteLine("Enter State: ");
                string state = Console.ReadLine();
                var DuplicateCheck = addressList.Where(e => e.State.Equals(state));
                foreach (var contact in DuplicateCheck)
                {
                    Console.WriteLine(contact.FirstName + "\t" + contact.LastName + "\t" + contact.City + "\t" + contact.MobileNumber + "\t" + contact.Zip + "\t" + contact.Address + "\t" + contact.Email + "\t" + contact.State);
                }
            }
            else
                Console.WriteLine("\nEnter Valid Input");
        }
        public void CountContact()
        {
            Console.WriteLine("\nEnter 1 to Count by City \nEnter 2 to Count by State");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Enter City: ");
                string city = Console.ReadLine();
                List<Contact> cityList = addressList.FindAll(e => e.City == city);
                Console.WriteLine("The Number of contact persons in the city {0} are : {1}", city, cityList.Count());
            }
            if (input == 2)
            {
                Console.WriteLine("Enter State: ");
                Console.WriteLine("Enter the state name to check its count : ");
                string state = Console.ReadLine();
                List<Contact> stateList = addressList.FindAll(e => e.State == state);
                Console.WriteLine("The number of contact persons in the state {0} are : {1}", state, stateList.Count());
            }
        }
        public void AddressBookSorting()
        {
            Console.WriteLine("\nEnter the following Options to Sort by: \n1.Name \n2.City \n3.State \n4.Zip");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    var SortByName = addressList.OrderByDescending(x => x.FirstName);
                    Console.WriteLine("\nSorted Contacts by Name :- ");
                    foreach (var item in SortByName)
                    {
                        Console.WriteLine(item.FirstName + "\t" + item.LastName + "\t" + item.City + "\t" + item.MobileNumber + "\t" + item.Zip + "\t" + item.Address + "\t" + item.Email + "\t" + item.State);
                    }
                    break;
                case 2:
                    var SortByCity = addressList.OrderByDescending(x => x.City);
                    Console.WriteLine("\nSorted Contacts by City :- ");
                    foreach (var item in SortByCity)
                    {
                        Console.WriteLine(item.FirstName + "\t" + item.LastName + "\t" + item.City + "\t" + item.MobileNumber + "\t" + item.Zip + "\t" + item.Address + "\t" + item.Email + "\t" + item.State);
                    }
                    break;
                case 3:
                    var SortByState = addressList.OrderByDescending(x => x.State);
                    Console.WriteLine("\nSorted Contacts by State :- ");
                    foreach (var item in SortByState)
                    {
                        Console.WriteLine(item.FirstName + "\t" + item.LastName + "\t" + item.City + "\t" + item.MobileNumber + "\t" + item.Zip + "\t" + item.Address + "\t" + item.Email + "\t" + item.State);
                    }
                    break;
                case 4:
                    var SortByZip = addressList.OrderByDescending(x => x.Zip);
                    Console.WriteLine("\nSorted Contacts by Zip :- ");
                    foreach (var item in SortByZip)
                    {
                        Console.WriteLine(item.FirstName + "\t" + item.LastName + "\t" + item.City + "\t" + item.MobileNumber + "\t" + item.Zip + "\t" + item.Address + "\t" + item.Email + "\t" + item.State);
                    }
                    break;
            }
        }
        public void ReadFile()
        {
            Console.WriteLine("The Contact details in the file after reading : \n ");
            string filePath = @"C:\BridgeLabz\AddressBook_System\AddressBook_System\File\TextFile.txt";
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);
        }
        public void WritingUsingStreamWriter()
        {
            Console.WriteLine("\nThe Contact details in the file after writing : ");
            String filePath = @"C:\BridgeLabz\AddressBook_System\AddressBook_System\File\TextFile.txt";
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine("Account Number : 8965300075");
                writer.Close();
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
        public void ReadWriteAsCsv()
        {
            string importFilePath = @"C:\BridgeLabz\AddressBook_System\AddressBook_System\File\import.csv";
            string exportFilePath = @"C:\BridgeLabz\AddressBook_System\AddressBook_System\File\export.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Read data successfully from import csv");
                foreach (var data in records)
                {
                    Console.WriteLine(data.FirstName + "\t" + data.LastName + "\t" + data.Address + "\t" + data.City + "\t" + data.State + "\t" + data.Zip + "\t" + data.MobileNumber + "\t" + data.Email + "\t" + data.UniqueName + "\n");
                }
                Console.WriteLine("\nHere reading from import csv file and write to export csv file");
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
                Console.WriteLine("The data is written in export csv file");
            }
        }
    }
}
