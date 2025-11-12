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
        public int ContactCount => contacts.Count;
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
        public void EditContact(string firstName)
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available to edit. Please add a contact first!");
                return;
            }
            Contact contact = contacts.FirstOrDefault(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));


            Console.WriteLine($"\nEditing contact: {contact.FirstName} {contact.LastName}");
            Console.WriteLine("Which field would you like to edit?");
            Console.WriteLine("1. Address\n2. City\n3. State\n4. Zip\n5. Phone\n6. Email");
            Console.Write("Enter your choice (1–6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter new Address: ");
                    contact.Address = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Enter new City: ");
                    contact.City = Console.ReadLine();
                    break;
                case "3":
                    Console.Write("Enter new State: ");
                    contact.State = Console.ReadLine();
                    break;
                case "4":
                    Console.Write("Enter new Zip: ");
                    contact.Zip = Console.ReadLine();
                    break;
                case "5":
                    Console.Write("Enter new Phone Number: ");
                    contact.PhoneNumber = Console.ReadLine();
                    break;
                case "6":
                    Console.Write("Enter new Email: ");
                    contact.Email = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice. No changes made.");
                    return;
            }

            Console.WriteLine("\nContact updated successfully!\n");
        }
        public void DeleteContact(string firstName)
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available to delete. Please add a contact first!");
                return;
            }
            Contact contact = contacts.FirstOrDefault(c =>c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }
            contacts.Remove(contact);
            Console.WriteLine($"Contact '{firstName} {contact.LastName}' deleted successfully!\n");
        }
    }
}