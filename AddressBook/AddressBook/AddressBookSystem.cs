using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookSystem
    {
        private Dictionary<string, Book> books = new();

        public void AddAddressBook(string name)
        {
            if (!books.ContainsKey(name))
            {
                books[name] = new Book();
                Console.WriteLine($"Address Book '{name}' created.");
            }
            else
            {
                Console.WriteLine("Address Book already exists!");
            }
        }

        public Book GetAddressBook(string name)
        {
            return books.ContainsKey(name) ? books[name] : null;
        }

        public void DisplayAddressBooks()
        {
            Console.WriteLine("\nAvailable Address Books:");
            foreach (var key in books.Keys)
                Console.WriteLine($"- {key}");
        }
    }
}

