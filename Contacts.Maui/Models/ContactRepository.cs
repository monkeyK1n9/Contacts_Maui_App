using System;
namespace Contacts.Maui.Models
{
	public static class ContactRepository
	{
		public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact { ContactId = 0, Name = "John Doe", Email = "JohnDoe@gmail.com" },
            new Contact { ContactId = 1, Name = "Guillaume djio", Email = "Guillaume@gmail.com" },
            new Contact { ContactId = 2, Name = "Eric Paul", Email = "Eric@g.com" },
            new Contact { ContactId = 3, Name = "Stephen Jack", Email = "Stephen@hotlook.com" }
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);

            if (contact != null)
            {
                return new Contact
                {
                    ContactId = contact.ContactId,
                    Name = contact.Name,
                    Email = contact.Email,
                    Phone = contact.Phone,
                    Address = contact.Address,
                };
            }

            return null;
        }

        public static void UpdateContact(int contactId, Contact contact)
        {
            if (contactId != contact.ContactId) return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);

            if (contactToUpdate != null)
            {
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.Phone = contact.Phone;
                contactToUpdate.Address = contact.Address;
            }

        }

        public static void AddContact(Contact contact)
        {
            var maxId = _contacts.Max(x => x.ContactId);
            contact.ContactId = maxId + 1;

            _contacts.Add(contact);
        }

        public static void DeleteContact(Contact contact)
        {
            _contacts.Remove(contact);
        }
    }
}

