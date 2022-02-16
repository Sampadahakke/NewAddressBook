using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAddressBook
{
    internal class AddressBookLibrary
    {
        //Creating Dictionary For AddressBooks
        public Dictionary<string, AddressBook> Library;

        //Initializing Dictionary
        public AddressBookLibrary()
        {
            Library = new Dictionary<string, AddressBook>();
        }

        public void AddAddressBook(AddressBook addressBook)
        {
            Console.WriteLine("Enter name of new addressbook");
            string name = Console.ReadLine();
            
        }
    }
}
