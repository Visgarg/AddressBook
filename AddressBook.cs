using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddressBook
    {
        Dictionary<string, List<ContactDetails>> addressBookDictionary;
        public AddressBook()
        {
            addressBookDictionary = new Dictionary<string, List<ContactDetails>>();
        }
        public void AddingAddressBook(List<ContactDetails> contactDetailsList)
        {
            Console.WriteLine("Please enter the  name of address book");
            string nameOfAddressBook = Console.ReadLine();
            addressBookDictionary.Add(nameOfAddressBook, contactDetailsList);
            
        }
        public void DisplayAddressBook()
        {
            foreach(KeyValuePair<string,List<ContactDetails>> addressBookDictionaryValues in addressBookDictionary)
            {
                Console.WriteLine(addressBookDictionaryValues.Key);
            }
        }
    }
}
