using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyContacts.Models
{
    public class ContactsService
    {
        public List<Contact> GetAll()
        {
            return this.GetFakeContacts();
        }

        private List<Contact> GetFakeContacts()
        {
            return new List<Contact>
            {
                new Contact
                { 
                    Id = 1,
                    FirstName = "Carol ",
                    LastName = "Fegley",
                    Phone = "303-268-1174",
                    Email = "CarolRFegley@jourrapide.com"
                },
                new Contact
                { 
                    Id = 2,
                    FirstName = "Kimberly",
                    LastName = "Henry",
                    Phone = "845-884-0738",
                    Email = "KimberlyJHenry@rhyta.com"
                },
                new Contact
                { 
                    Id = 3,
                    FirstName = "Joe",
                    LastName = "Sullivan",
                    Phone = "401-763-3141",
                    Email = "JoePSullivan@teleworm.us"
                },
                new Contact
                { 
                    Id = 4,
                    FirstName = "Janice ",
                    LastName = "Vanallen",
                    Phone = "706-507-3361",
                    Email = "JaniceJVanallen@teleworm.us"
                },
                new Contact
                { 
                    Id = 5,
                    FirstName = "Wesley ",
                    LastName = "Gallo",
                    Phone = "407-256-6844",
                    Email = "WesleyAGallo@dayrep.com"
                },
                new Contact
                { 
                    Id = 6,
                    FirstName = "James ",
                    LastName = "Charlie",
                    Phone = "216-324-8260",
                    Email = "JamesBCharlie@teleworm.us"
                },
                new Contact
                { 
                    Id = 7,
                    FirstName = "Ellen",
                    LastName = "Petrin",
                    Phone = "405-742-6307",
                    Email = "EllenEPetrin@teleworm.us"
                }
            };
        }
    }
}