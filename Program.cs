using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Management System");
            //contactPersonInformation.AddingContactDetails("Lakshay", "Garg", "a", "b", "d", 3,5, "lakshay.garg");
            ContactPersonInformation contactPersonInformation = new ContactPersonInformation();
            contactPersonInformation.AddingContactDetails();
            contactPersonInformation.DisplayContactDetails();
           // AddressBook addressBook = new AddressBook();
            //addressBook.DisplayAddressBook();
            Console.WriteLine("Do you want to edit any details, enter y to edit.");
            string input = Console.ReadLine();
            if(input.ToLower()=="y")
            {
                contactPersonInformation.EditingContactDetails();
                contactPersonInformation.DisplayContactDetails();

            }
            Console.WriteLine("Do you want to delete anything from contact details, press y for delete");
            string inputForDelete = Console.ReadLine();
            if(inputForDelete.ToLower()=="y"|| inputForDelete=="Y")
            {
                contactPersonInformation.DeletingContactDetails();
                contactPersonInformation.DisplayContactDetails();
            }
        }
    }
}
