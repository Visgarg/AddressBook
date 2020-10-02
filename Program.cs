using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Management System");
            ContactPersonInformation contactPersonInformation = new ContactPersonInformation();
            contactPersonInformation.AddingContactDetails("Vishal", "Garg", "a", "b", "c", 1, 2, "vishal.garg");
            contactPersonInformation.AddingContactDetails("Lakshay", "Garg", "a", "b", "d", 3,5, "lakshay.garg");
            contactPersonInformation.DisplayContactDetails();
        }
    }
}
