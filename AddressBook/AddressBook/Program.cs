using System;
namespace AddressBook;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program!");
        AddressBookSystem system = new AddressBookSystem();
        Book currentBook = null;

        bool keepAdding = true;
        while (keepAdding)
        {
            Console.WriteLine("\n0. Create Address Book");
            Console.WriteLine("1. Select Address Book");
            Console.WriteLine("2. Add New Contact");
            Console.WriteLine("3. Display All Contacts");
            Console.WriteLine("4. Edit Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.Write("Enter Address Book Name: ");
                    system.AddAddressBook(Console.ReadLine());
                    break;
                case "1":
                    system.DisplayAddressBooks();
                    Console.Write("Enter Address Book Name: ");
                    currentBook = system.GetAddressBook(Console.ReadLine());
                    if (currentBook == null)
                        Console.WriteLine("Address Book not found!");
                    break;
                case "2":
                    currentBook.AddContact();
                    break;
                case "3":
                    currentBook.DisplayContacts();
                    break;
                case "4":
                    if(currentBook.ContactCount==0)
                    {
                        Console.WriteLine("No contacts available to edit.");
                        break;
                    }
                    Console.Write("Enter the First Name of the contact to edit: ");
                    string name = Console.ReadLine();
                    currentBook.EditContact(name);
                    break;
                case "5":
                    if (currentBook.ContactCount == 0)
                    {
                        Console.WriteLine("No contacts available to delete.");
                        break;
                    }
                    Console.Write("Enter the First Name of the contact to delete: ");
                    string deleteName = Console.ReadLine();
                    currentBook.DeleteContact(deleteName);
                    break;
                case "6":
                    keepAdding = false;
                    Console.WriteLine("\nThank you for using Address Book!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}