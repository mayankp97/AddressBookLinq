using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookLinq
{
    class AddressBookDBL
    {
        public DataTable dataTable = new DataTable();

        public void CreateAddressBook()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zipcode", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailID", typeof(string));
        }

        public void InsertValues()
        {
            dataTable.Rows.Add("Mayank", "Purohit", "Near Heaven", "cochi", "kerela", "155545", "9865656565", "m@gmail.com");
            dataTable.Rows.Add("Mahesh", "Purohit", "Near Hell", "chennai", "TN", "1658788", "95554545", "mp@gmail.com");
            dataTable.Rows.Add("Manish", "Purohit", "Near chinatown", "bengaluru", "Karnataka", "165301", "4545454545", "ma@gmail.com");
            dataTable.Rows.Add("Mukesh", "Purohit", "Near jawahar circle", "jodhpur", "Rajasthan", "6654554", "9845454545", "mu@gmail.com");
            dataTable.Rows.Add("Meena", "Purohit", "Near kala bazar", "kolkata", "WB", "5454545", "7784845455", "m@gmail.com");
            dataTable.Rows.Add("Minali", "Purohit", "Near lal bazar", "puri", "Orissa", "545454", "8876988998", "mi@gmail.com");


        }

        public void EditContact()
        {
            var name = "Mayank";
            var rowToUpdate = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(name)).FirstOrDefault();
            if (rowToUpdate != null)
            {
                rowToUpdate.SetField("PhoneNumber", "98989898");
                rowToUpdate.SetField("ZipCode", "5454545");
                Console.WriteLine("\nPhoneNumber and ZipCode of {0} updated successfully!", name);
                DisplayData();
            }
            else
            {
                Console.WriteLine("There is no such record in the Address Book!");
            }
        }

        public void DisplayData()
        {
            foreach (DataColumn col in dataTable.Columns)
            {
                Console.Write(col.ToString().PadRight(20));
            }
            Console.WriteLine("");
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.Write(row[col].ToString().PadRight(20));
                }
                Console.WriteLine();
            }
        }
    }
}
