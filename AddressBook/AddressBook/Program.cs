using System;
namespace AddressBook;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program!");
        Book book = new Book();

        bool keepAdding = true;
        while (keepAdding)
        {
            Console.WriteLine("\n1. Add New Contact");
            Console.WriteLine("2. Display All Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    book.AddContact();
                    break;
                case "2":
                    book.DisplayContacts();
                    break;
                case "3":
                    if(book.ContactCount==0)
                    {
                        Console.WriteLine("No contacts available to edit.");
                        break;
                    }
                    Console.Write("Enter the First Name of the contact to edit: ");
                    string name = Console.ReadLine();
                    book.EditContact(name);
                    break;
                case "4":
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