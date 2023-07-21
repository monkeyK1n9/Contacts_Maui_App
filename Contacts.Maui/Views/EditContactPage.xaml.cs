using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

[QueryProperty(nameof(ContactId), "Id")]

public partial class EditContactPage : ContentPage
{
	private Contact contact;

	public EditContactPage()
	{
		InitializeComponent();
	}

    void btnCancel_Clicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

	public string ContactId
	{
		set
		{
			contact = ContactRepository.GetContactById(int.Parse(value));
			if (contact != null)
			{
				contactCtrl.Name = contact.Name;
				contactCtrl.Email = contact.Email;
				contactCtrl.Phone = contact.Phone;
				contactCtrl.Address = contact.Address;
			}
		}
	}

    void btnUpdate_Clicked(System.Object sender, System.EventArgs e)
    {
		
		contact.Name = contactCtrl.Name;
		contact.Email = contactCtrl.Email;
		contact.Phone = contactCtrl.Phone;
		contact.Address = contactCtrl.Address;

		ContactRepository.UpdateContact(contact.ContactId, contact);
		Shell.Current.GoToAsync("..");
    }

    void contactCtrl_OnError(System.Object sender, System.String e)
    {
		DisplayAlert("Error", e, "Ok");
    }
}
