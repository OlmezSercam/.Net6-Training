using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace IEnumerable_Example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();
        }
    }
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Contact(string name, string phoneNumber) 
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public void Call()
        {
            Console.WriteLine("Calling to {0}. Phone number is {1}", Name,PhoneNumber);
        }
    }
    class PhoneBook : IEnumerable<Contact>
    {
        public List<Contact> Contacts;

        public PhoneBook() 
        {
            Contacts = new List<Contact>{
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
        }

        IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
