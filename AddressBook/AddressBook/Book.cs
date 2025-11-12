using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Book
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact()
        {
            Contact contact = new Contact();
            Console.Write("Enter First Name: "); 
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: "); 
            contact.LastName = Console.ReadLine();
            Console.Write("Enter Address: "); 
            contact.Address = Console.ReadLine();
            Console.Write("Enter City: "); 
            contact.City = Console.ReadLine();
            Console.Write("Enter State: "); 
            contact.State = Console.ReadLine();
            Console.Write("Enter Zip: "); 
            contact.Zip = Console.ReadLine();
            Console.Write("Enter Phone: "); 
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Email: "); 
            contact.Email = Console.ReadLine();

            contacts.Add(contact);
            Console.WriteLine("\nContact added successfully!\n");
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            Console.WriteLine("\nAll Contacts:\n");
            foreach (var contact in contacts)
                Console.WriteLine(contact+"\n");
            
        }
    }
}