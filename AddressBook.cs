using System;
using System.Collections.Generic;

namespace Address
{
    public class AddressBook
    {
        public List<Contact> contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact name)
        {
            var test = contacts.Find(contact => contact == name);
            try
            {
                if (test == null)
                {
                    contacts.Add(name);
                }
                else
                {
                    throw new NotSupportedException();
                }
            }
            catch (NotSupportedException)
            {
                Console.WriteLine($"{name.FullName} already exists in your address book.");
            }
        }

        public List<Contact> GetByEmail(string email)
        {
            var match = contacts.FindAll(contact => contact.Email == email);
            return match;
        }
    }
}