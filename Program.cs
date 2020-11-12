using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book system Linq");

            var addressBookDB = new AddressBookDBL();
            addressBookDB.CreateAddressBook();
            addressBookDB.InsertValues();
            addressBookDB.DisplayData();
            addressBookDB.EditContact();
            addressBookDB.DisplayData();

        }
    }
}
