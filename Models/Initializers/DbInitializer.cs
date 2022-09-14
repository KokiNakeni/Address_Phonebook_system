using ContactsAddressManagement.Models;
using System;
using System.Linq;

namespace ContactsAddressManagement.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ContactManagementContext context)
        {
            context.Database.EnsureCreated();

            if (context.Contacts.Any())
            {
                return; 
            }

            var contacts = new Contact[]
            {
                new Contact{FirstName="Carson",Surname="Alexander",DateOfBirth=DateTime.Parse("2005-09-01"),CellphoneNumber="0659533637"},
                new Contact{FirstName="Meredith",Surname="Alonso",DateOfBirth=DateTime.Parse("2002-09-01"),CellphoneNumber="0659533637"},
                new Contact{FirstName="Arturo",Surname="Anand",DateOfBirth=DateTime.Parse("2003-09-01"),CellphoneNumber="0659533637"},
                new Contact{FirstName="Gytis",Surname="Barzdukas",DateOfBirth=DateTime.Parse("2002-09-01"),CellphoneNumber="0659533637"},
            };

            foreach (var contact in contacts)
            {
                context.Contacts.Add(contact);
            }


            var contactAddress = new ContactAddress[]
            {
                new ContactAddress{ContactId=1,StreetName="Babass st",City="JHB",State ="Gauteng",Country="South Africa",ZipCode="aa"},
                new ContactAddress{ContactId=2,StreetName="tuton st",City="CPT",State ="KZN",Country="South Africa",ZipCode="aa"},
                new ContactAddress{ContactId=3,StreetName="tshepo st",City="PTA",State ="Western Cape",Country="South Africa",ZipCode="aa"},
                new ContactAddress{ContactId=4,StreetName="mpho st",City="Venda",State ="Eastern Cape",Country="South Africa",ZipCode="aa"},
            };
            foreach (ContactAddress c in contactAddress)
            {
                context.ContactAddresses.Add(c);
            }

            context.SaveChanges();

        }
    }
}
