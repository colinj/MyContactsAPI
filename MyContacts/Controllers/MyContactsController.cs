using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyContacts.Models;

namespace MyContacts.Controllers
{
    public class MyContactsController : ApiController
    {
        private ContactsService contactService;

        public MyContactsController()
        {
            contactService = new ContactsService();
        }

        public IEnumerable<Contact> Get()
        {
            return contactService.GetAll();
        }

        public Contact Get(int id)
        {
            var contact = contactService.GetAll()
                                        .Where(c => c.Id == id)
                                        .SingleOrDefault();

            if (contact == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"No contact with Id = {id}"),
                    ReasonPhrase = "Contact Not Found"
                };

                throw new HttpResponseException(resp);
            }

            return contact;
        }
    }
}
