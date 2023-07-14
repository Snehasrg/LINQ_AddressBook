using LINQAddressBook;

namespace LINQAddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Contacts> contacts = new List<Contacts>();
            AddressBook address = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Perform Operation\n1.Add Contact\n2.Display By Descending Order\n" +
                    "3.Skip Top 3 Records\n4.Get Records(FirstName,LastName and PhoneNumber)\n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contacts.Add(new Contacts { FirstName = "Shreya", LastName = "Jadhav", Address = "Mumbai", City = "Mumbai", State = "Maharashtra", ZIP = "555444", PhoneNumber = "98989898", Email = "shreya@gmail.com" });
                        contacts.Add(new Contacts { FirstName = "shruti", LastName = "Joshi", Address = "UP", City = "UP", State = "UP", ZIP = "222111", PhoneNumber = "78787878", Email = "shruti@gmail.com" });
                        contacts.Add(new Contacts { FirstName = "shivani", LastName = "Patil", Address = "pune", City = "pune", State = "Maharashtra", ZIP = "333222", PhoneNumber = "9696969696", Email = "sp@gmail.com" });
                        contacts.Add(new Contacts { FirstName = "shradha", LastName = "kumar", Address = "punjab", City = "punjab", State = "punjab", ZIP = "444333", PhoneNumber = "86868686", Email = "sk@gmail.com" });
                        contacts.Add(new Contacts { FirstName = "shital", LastName = "Gawde", Address = "Bihar", City = "Bihar", State = "Bihar", ZIP = "777666", PhoneNumber = "8878787878", Email = "sg@gmail.com" });
                        Console.WriteLine("Contact Deatils In AddressBook");
                        Console.WriteLine("===============================");
                        foreach (var data in contacts)
                        {
                            Console.WriteLine($"FirstName:- {data.FirstName} \n LastName:- {data.LastName} \n Address:- {data.Address} \n City:- {data.City} \n {data.State} \n Zip:- {data.ZIP} \n PhoneNumber:- {data.PhoneNumber} \n Email:- {data.Email}");
                            Console.WriteLine(" ");
                        }
                        break;
                    case 2:                   
                        address.TopRecords(contacts);
                        break;
                    case 3:
                        address.SkipRecords(contacts);
                        break;
                    case 4:
                        address.GetRecords(contacts);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}