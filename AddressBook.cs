using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAddressBook
{
    public class AddressBook
    {
        public void TopRecords(List<Contacts> contacts)
        {
            var result = (from contact in contacts orderby contact.FirstName descending select contact);
            foreach (var data in result)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \n LastName:- {data.LastName} \n Address:- {data.Address} \n City:- {data.City} \n {data.State} \n Zip:- {data.ZIP} \n PhoneNumber:- {data.PhoneNumber} \n Email:- {data.Email}");
                Console.WriteLine("");
            }
        }
        public void SkipRecords(List<Contacts> contacts)
        {
            var result = (from contact in contacts orderby contact.FirstName descending select contact).Skip(3);
            foreach (var data in result)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \n LastName:- {data.LastName} \n Address:- {data.Address} \n " +
                    $"City:- {data.City} \n {data.State} \n Zip:- {data.ZIP} \n PhoneNumber:- {data.PhoneNumber} \n Email:- {data.Email}");
                Console.WriteLine("");
            }
        }
        public void GetRecords(List<Contacts> contacts)
        {
            var result = (from contact in contacts select contact);
            foreach (var data in result)
            {
                Console.WriteLine($"FirstName:- {data.FirstName} \t LastName:- {data.LastName} " +
                                    $"\t PhoneNumber:- {data.PhoneNumber}");
            }
        }
    }
}
