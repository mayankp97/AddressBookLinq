using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book system Linq");

            var addressBookDB = new AddressBookDBL();
            //Creating And inserting values in Table
            addressBookDB.CreateAddressBook("MyAB");
            addressBookDB.InsertValues();
            addressBookDB.DisplayData();
            /*
            //Updating a contact
            addressBookDB.EditContact();
            */
            //addressBookDB.DeleteContact("Meena");
            //addressBookDB.DisplayData();
            /*
            //Retrieving Contacts By city and state
            addressBookDB.RetrieveContactsByCity("cochi");
            addressBookDB.RetrieveContactsByState("WB");
            */
            /*
            //Getting Size by count of city and state
            addressBookDB.CountByCity();
            addressBookDB.CountByState();
            */

            //Retrieving Contacts Albhabetically
            addressBookDB.RetrievAlbhabetically("cochi");

        }
    }
}
